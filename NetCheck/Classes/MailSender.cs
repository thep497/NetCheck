using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NNSClass
{
    class MailSender
    {
        private string smtpServer;
        private int smtpPort;
        private string username;
        private string password;
        private string mailFrom;
        private string mailTo;
        private string subject;
        private string body;

        public MailSender(string _smtpServer,
                          int _smtpPort,
                          string _username,
                          string _password,
                          string _mailFrom,
                          string _mailTo,
                          string _subject,
                          string _body)
        {
            this.smtpServer = _smtpServer;
            this.smtpPort = _smtpPort;
            this.username = _username;
            this.password = _password;
            this.mailFrom = _mailFrom;
            this.mailTo = _mailTo;
            this.subject = _subject;
            this.body = _body;
        }

        public bool CanSendMail
        {
            get
            {
                return !string.IsNullOrWhiteSpace(smtpServer) &&
                       smtpPort > 0 && 
                       !string.IsNullOrWhiteSpace(username) &&
                       !string.IsNullOrWhiteSpace(password) &&
                       !string.IsNullOrWhiteSpace(mailFrom) &&
                       !string.IsNullOrWhiteSpace(mailTo) &&
                       !string.IsNullOrWhiteSpace(subject);
            }
        }
        public void SendMail()
        {
            SmtpClient client = new SmtpClient(smtpServer,smtpPort);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(username, password);

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(mailFrom);
            mailMessage.To.Add(mailTo);
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            client.Send(mailMessage);
        }
    }
}
