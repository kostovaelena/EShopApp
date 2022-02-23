using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using EShopApp.Domain;

using EShopApp.Services.Interface;


namespace EShopApp.Controllers
{
    public class WinesController : Controller
    {
        private readonly IProductService _productService;


        public WinesController(IProductService productServicet)
        {
            _productService = productServicet;
            
        }


        public IActionResult AddToShoppingCart(Guid? id)
        {
            var model = this._productService.GetShoppingCartInfo(id);
            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToShoppingCart([Bind("WineId", "Quantity")] AddToShoppingCart item)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result = this._productService.AddToShoppingCart(item, userId);

            if (result)
            {
                return RedirectToAction("Index", "Wines");
            }

            return View(item);
        }





        // GET: Wines
        public IActionResult Index(string sortOrder)
        {
            
            var allProducts = this._productService.GetAllProducts();
            return View(allProducts);
        }





        // GET: Wines/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wine = this._productService.GetDetailsForProduct(id);
               
            this._productService.GetDetailsForProduct(id);
            if (wine == null)
            {
                return NotFound();
            }

            return View(wine);
        }


        // GET: Wines/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Wines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public IActionResult Create([Bind("Id,Image,Vinarija,Zemja,Godina,Kategorija,Price")] Wine wine)
        {
            if (ModelState.IsValid)
            {
                this._productService.CreateNewProduct(wine);
                return RedirectToAction(nameof(Index));
            }
            return View(wine);
        }


        // GET: Wines/Edit/5
        [Authorize(Roles = "Administrator")]
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wine = this._productService.GetDetailsForProduct(id);
            if (wine == null)
            {
                return NotFound();
            }
            return View(wine);
        }

        // POST: Wines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public IActionResult Edit(Guid id, [Bind("Id,Image,Godina,Price")] Wine wine)
        {
            if (id != wine.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._productService.UpdeteExistingProduct(wine);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WineExists(wine.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(wine);
        }


        // GET: Wines/Delete/5
        [Authorize(Roles = "Administrator")]
        public  IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wine = this._productService.GetDetailsForProduct(id);
            if (wine == null)
            {
                return NotFound();
            }

            return View(wine);
        }

        // POST: Wines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            this._productService.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }

        private bool WineExists(Guid id)
        {
            return this._productService.GetDetailsForProduct(id) != null;
        }



/*
        [HttpGet]
        public FileContentResult ExportAllWines()
        {
            string fileName = "Wine.xlsx";
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet worksheet = workbook.Worksheets.Add("Wines");

                worksheet.Cell(1, 1).Value = "Wine Id";
                worksheet.Cell(1, 2).Value = "Costumer Email";



                HttpClient client = new HttpClient();


                string URI = "https://localhost:44336/Admin/GetAllProducts";

                HttpResponseMessage responseMessage = client.GetAsync(URI).Result;

                var result = responseMessage.Content.ReadAsAsync<List<Wine>>().Result;

                for (int i = 1; i <= result.Count(); i++)
                {
                    var item = result[i - 1];

                    worksheet.Cell(i + 1, 1).Value = item.Id.ToString();
                   *//* worksheet.Cell(i + 1, 2).Value = item.User.Email;*//*

                    for (int p = 0; p < item.List<Wine>w.Count(); p++)
                    {
                        worksheet.Cell(1, p + 3).Value = "Product-" + (p + 1);
                        worksheet.Cell(i + 1, p + 3).Value = item.wine.ElementAt(p).Vinarija;
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
*/

        public IActionResult FilterByKategorija(String kategorija)
        {
            Kategorija kategorijaEnum = (Kategorija)Enum.Parse(typeof(Kategorija), kategorija);

            var allTickets = this._productService.FilterByKategorija(kategorijaEnum);

            return View("Index", allTickets);
        }
        private bool TicketExists(Guid id)
        {
            return this._productService.GetDetailsForProduct(id) != null;
        }


        public IActionResult FilteredWines(int godina)
        {
            var allTickets = this._productService.GetFilteredWines();
            return View(allTickets);
        }

        


    }
}
