using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Data;
using MainApplicaion.Models;
using System.Data.Entity;
using MainApplicaion.Data;
using System.Net.Sockets;
using System.Net.Mail;
using System.Net;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {



        private readonly MainApplicaionContext _db;


        

        private readonly IConfiguration _configuration;
        [BindProperty]
        public HumReg Registration { get; set; }

        public IndexModel(MainApplicaionContext db, IConfiguration configuration) 
        {
            _db= db;
            _configuration = configuration;
        }






        public async Task<IActionResult> OnPost()
        {
           await _db.HumReg.AddAsync(Registration);
           await _db.SaveChangesAsync();



            var mail = new MailMessage();
            mail.From = new MailAddress(_configuration["EmailSettings:EmailFromAddress"]);
            mail.To.Add("ijeremyngo2@gmail.com");
            mail.Subject = "HumReg " + $"{Registration.Id}";
            mail.Body = $"A new customer has been added to the database: " +
                $"{Registration.Id} {Registration.Model} {Registration.Serial} {Registration.MachineName} " +
                $"{Registration.ShipDate}  {Registration.InstallDate} {Registration.Customer} " +
                $"{Registration.CustomerContact} {Registration.CustomerPhone} {Registration.CustomerEmail} " +
                $"{Registration.CustomerAddress} {Registration.CustomerUnit} {Registration.CustomerCity} {Registration.CustomerState} " +
                $"{Registration.CustomerZip} {Registration.Provider}  {Registration.ProviderPhone} " +
                $"{Registration.ProviderEmail} {Registration.ProviderAddress} {Registration.ProviderUnit} {Registration.ProviderCity} " +
                $"{Registration.ProviderState} {Registration.ProviderZip} {Registration.Technician} {Registration.TechnicianPhone} " +
                $"{Registration.TechnicianEmail} {Registration.UpsManufacturer} {Registration.UpsModel} {Registration.UpsSerial} ({Registration.CustomerEmail})";


            var smtp = new SmtpClient("smtp.gmail.com", 465);

            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential(_configuration["EmailSettings:EmailFromAddress"], _configuration["EmailSettings:EmailPassword"]);
            smtp.Send(mail);





            return RedirectToPage("Index");

            
        }

    }
}