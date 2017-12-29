using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentCoder.Models;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Configuration;
using RentCoder.Repository;
using RedWillow.MvcToastrFlash;
namespace RentCoder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RegistrationViewModel register = new RegistrationViewModel();

            register.EmployementTypes = new List<EmployementTypes>();
            register.EmployementTypes.Add(new EmployementTypes { TypeId = 1, Name = "Full Time" });
            register.EmployementTypes.Add( new EmployementTypes { TypeId = 2, Name = "Part Time" });
            register.Years = new List<int>();
            register.Years.AddRange(Enumerable.Range(1, 25));
            return View(register);
        }

        public ActionResult BasicRegistration()
        {
            return View();
        }
        public ActionResult RegisterEmployer(RegistrationViewModel model)
        {
            var body = createRentCoderEmailBody(model);
            SendHtmlFormattedEmailtoSupport(model, body);
            body = createClientEmailBody(model);
            SendHtmlFormattedEmailtoClient(model, body);

            this.AddToastMessage("Success", "Thank you for your enquiry and Our team will get back to you soon !", ToastType.Success);
            return RedirectToAction("Index", "Home");
        }
      
        private void SendHtmlFormattedEmailtoClient(RegistrationViewModel alert, string body)

        {
            try
            {
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(ConfigurationManager.AppSettings["FromMail"]);
                    mailMessage.Subject = "Received Enquiry from </>RentCoder";
                    mailMessage.Body = body;

                    mailMessage.IsBodyHtml = true;

                    mailMessage.To.Add(new MailAddress(alert.Email));

                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = ConfigurationManager.AppSettings["Host"];

                    smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);

                    System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();

                    NetworkCred.UserName = ConfigurationManager.AppSettings["FromMail"]; //reading from web.config  

                    NetworkCred.Password = ConfigurationManager.AppSettings["Password"]; //reading from web.config  

                    smtp.UseDefaultCredentials = true;

                    smtp.Credentials = NetworkCred;

                    smtp.Port = int.Parse(ConfigurationManager.AppSettings["Port"]); //reading from web.config  

                    smtp.Send(mailMessage);

                }
            }
            catch (Exception e)
            {
            }

        }

        private void SendHtmlFormattedEmailtoSupport(RegistrationViewModel alert, string body)

        {
            try
            {
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(alert.Email);
                    mailMessage.Subject = string.Format("Received Enquiry from {0}", alert.Name);
                    mailMessage.Body = body;

                    mailMessage.IsBodyHtml = true;

                    mailMessage.To.Add(new MailAddress(ConfigurationManager.AppSettings["FromMail"]));

                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = ConfigurationManager.AppSettings["Host"];

                    smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);

                    System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();

                    NetworkCred.UserName = ConfigurationManager.AppSettings["FromMail"]; //reading from web.config  

                    NetworkCred.Password = ConfigurationManager.AppSettings["Password"]; //reading from web.config  

                    smtp.UseDefaultCredentials = true;

                    smtp.Credentials = NetworkCred;

                    smtp.Port = int.Parse(ConfigurationManager.AppSettings["Port"]); //reading from web.config  

                    smtp.Send(mailMessage);

                }
            }
            catch (Exception e)
            {
            }

        }
        private string createClientEmailBody(RegistrationViewModel alert)

        {

            string body = string.Empty;
            //using streamreader for reading my htmltemplate   
            string path = Server.MapPath("../RentCoder.html"); // System.IO.Path.GetDirectoryName(Exepath);

            using (StreamReader reader = new StreamReader(path))

            {

                body = reader.ReadToEnd();

            }

            body = body.Replace("{name}", alert.Name); //replacing the required things  

            return body;

        }

        private string createRentCoderEmailBody(RegistrationViewModel alert)

        {

            string body = string.Empty;
            //using streamreader for reading my htmltemplate   
            string path = Server.MapPath("../SupportMail.html"); // System.IO.Path.GetDirectoryName(Exepath);

            using (StreamReader reader = new StreamReader(path))

            {

                body = reader.ReadToEnd();

            }

            body = body.Replace("{name}", alert.Name); //replacing the required things 
            body = body.Replace("{technology}", alert.Technology);
            body = body.Replace("{experiance}", alert.Experiance);
            body = body.Replace("{Contact}", alert.Contact);
            body = body.Replace("{email}", alert.Email);
            body = body.Replace("{employementType}", alert.EmployementType);
            return body;

        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}