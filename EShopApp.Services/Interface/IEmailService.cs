using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EShopApp.Domain;

namespace EShopApp.Services.Interface
{
    public interface IEmailService
    {
        Task SendEmailAsync(List<EmailMessage> allMails);
    }
}
