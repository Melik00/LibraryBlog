using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using KutuphaneBlog.Entity;
using System.Net;

namespace KutuphaneBlog
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        DboGemlikKitabevimEntities db = new DboGemlikKitabevimEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBL_ILETISIM t = new TBL_ILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.TELEFON = TextBox3.Text;
            t.KONU = TextBox4.Text;
            t.MESAJ = TextBox5.Text;
            db.TBL_ILETISIM.Add(t);
            db.SaveChanges();

            string adSoyad = TextBox1.Text;
            string mail = TextBox2.Text;
            string telefon = TextBox3.Text;
            string konu = TextBox4.Text;
            string mesaj = TextBox5.Text;

            string emailBody = $"Ad Soyad: {adSoyad}\n" +
                               $"Mail: {mail}\n" +
                               $"Telefon: {telefon}\n" +
                               $"Konu: {konu}\n" +
                               $"Mesaj: {mesaj}";

            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("your-email@example.com"); // Kendi e-posta adresinizi buraya girin
                mailMessage.To.Add("gemlikkitabevim@gmail.com");
                mailMessage.Subject = "İletişim Formu: " + konu;
                mailMessage.Body = emailBody;

                SmtpClient smtpClient = new SmtpClient("smtp.example.com"); // SMTP sunucu adresi
                smtpClient.Port = 587; // SMTP portu
                smtpClient.Credentials = new NetworkCredential("your-email@example.com", "your-email-password"); // Kendi e-posta adresiniz ve şifreniz
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);

                Response.Write("<script>alert('Mesajınız başarıyla gönderildi.');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Mesaj gönderilirken bir hata oluştu: " + ex.Message + "');</script>");
            }

        }
    }
}


