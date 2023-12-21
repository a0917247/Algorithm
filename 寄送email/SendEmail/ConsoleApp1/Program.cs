using System.Net.Mail;
using System.Net;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 發送郵件的帳號資訊
            string senderEmail = "willsonlee999@gmail.com";
            string senderPassword = "ehfffaomejstsgsn";

            // 收件人的郵箱地址
            string recipientEmail = "a0917243@gmail.com";

            // 創建並初始化 MailMessage
            var mail = new MailMessage
            {
                From = new MailAddress(senderEmail),
                Subject = "通知信件",
                Body = "莉爾是哥哥的老婆。",
                IsBodyHtml = false
            };

            // 添加收件人
            mail.To.Add(recipientEmail);

            // 使用 SmtpClient 寄送郵件
            
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(senderEmail, senderPassword),
                EnableSsl = true,
            };
            try
            {
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"郵件寄送失敗：{ex.Message}");
            }
            finally 
            {
                smtpClient.Dispose();
            }
        }
    }
}

