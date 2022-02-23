//using ClosedXML.Excel;
using EShopApp.Domain;
//using GemBox.Document;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EShopApp.Services.Interface;
using GemBox.Document;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;

namespace EShopApp.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrderService _orderService;


        public OrderController(IOrderService orderService)
        {
            this._orderService = orderService;
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");

        }

        


        public IActionResult Index()
        {
            HttpClient client = new HttpClient();


            string URI = "https://localhost:44385/Admin/GetOrders";

            HttpResponseMessage responseMessage = client.GetAsync(URI).Result;

            var result = responseMessage.Content.ReadAsAsync<List<Order>>().Result;

            return View(result);
        }

        public IActionResult Details(Guid id)
        {
            BaseEntity baseEntity = new BaseEntity();
            baseEntity.Id = id;

            Order result = this._orderService.getOrderDetails(baseEntity);

            return View(result);
        }
       
        [HttpGet]
        public FileContentResult CreateInvoice(Guid id)
        {

            BaseEntity baseEntity = new BaseEntity();
            baseEntity.Id = id;

            Order result = this._orderService.getOrderDetails(baseEntity);


            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Invoice.docx");
            var document = DocumentModel.Load(templatePath);


            document.Content.Replace("{{OrderNumber}}", result.Id.ToString());
            document.Content.Replace("{{UserName}}", result.User.UserName);

            StringBuilder sb = new StringBuilder();

            var totalPrice = 0;

            foreach (var item in result.WineInOrders)
            {
                totalPrice += item.Quantity * item.OrderedWine.Price;
                sb.AppendLine(item.OrderedWine.Vinarija + " with quantity of: " + item.Quantity + " and price of: " + item.OrderedWine.Price + "МКД");
            }


            document.Content.Replace("{{ProductList}}", sb.ToString());
            document.Content.Replace("{{TotalPrice}}", totalPrice.ToString() + "МКД");


            var stream = new MemoryStream();

            document.Save(stream, new PdfSaveOptions());

            return File(stream.ToArray(), new PdfSaveOptions().ContentType, "ExportInvoice.pdf");
        }


        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public FileContentResult ExportAllOrders()
        {
            string fileName = "Orders.xlsx";
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet worksheet = workbook.Worksheets.Add("Orders");

                worksheet.Cell(1, 1).Value = "Order Id";
                worksheet.Cell(1, 2).Value = "Costumer Email";
                


                HttpClient client = new HttpClient();


                string URI = "https://localhost:44385/Admin/GetOrders";

                HttpResponseMessage responseMessage = client.GetAsync(URI).Result;

                var result = responseMessage.Content.ReadAsAsync<List<Order>>().Result;

                for (int i = 1; i <= result.Count(); i++)
                {
                    var item = result[i - 1];

                    worksheet.Cell(i + 1, 1).Value = item.Id.ToString();
                    worksheet.Cell(i + 1, 2).Value = item.User.Email;

                    for (int p = 0; p < item.WineInOrders.Count(); p++)
                    {
                        worksheet.Cell(1, p + 3).Value = "Product-" + (p + 1);
                        worksheet.Cell(i + 1, p + 3).Value = item.WineInOrders.ElementAt(p).OrderedWine.Vinarija;
                    }
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(content, contentType, fileName);
                }

            }
        }

    }
}
