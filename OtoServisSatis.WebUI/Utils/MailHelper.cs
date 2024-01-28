using OtoServisSatis.Entities;
using System.Net;
using System.Net.Mail;

namespace OtoServisSatis.WebUI.Utils
{
    public class MailHelper
    {
        public static async Task SendMailAsync(Musteri musteri)
        {
            SmtpClient smtpClient = new SmtpClient("mail.UludagGallery.com", 587);
            smtpClient.Credentials = new NetworkCredential("Evrenuludag563@gmail.com", "Evren168420Uludag");
            smtpClient.EnableSsl = true;
            MailMessage message = new MailMessage();
            message.From = new MailAddress("Evrenuludag563@gmail.com");
            message.To.Add("Evrenuludag563@gmail.com");
            message.Subject = "𝓤𝓵𝓾𝓭𝓪𝓰̆ 𝓖𝓪𝓵𝓮𝓻𝓲";
            message.Body = $"Mail Bilgileri <hr/> Ad Soyad : {musteri.Adi} {musteri.Soyadi} <hr/> İlgilendiği Araç Id : {musteri.AracId} <hr/> Email : {musteri.Email} <hr/> Telefon : {musteri.Telefon} <hr/> Notlar : {musteri.Notlar}";
            message.IsBodyHtml = true;
            smtpClient.Send(message);
            await smtpClient.SendMailAsync(message);
            smtpClient.Dispose();
        }
    }
}