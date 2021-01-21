// *******************************************************************
//1. Program Name:	NetCheck
//2. Module Name:	Class
//3. Unit Name:		MailSender
//4. Programmer:	thep497
//5. Create date:	20210121
//6. Description:	Class to send an e-mail
// *******************************************************************
// Revision : 0
// Edit history
// Rev 0: //th20210121 Initial this unit.
// *******************************************************************
using System.Net;
using System.Net.Mail;

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
        public bool SendMail()
        {
            try
            {
                SmtpClient client = new SmtpClient(smtpServer, smtpPort);
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(username, password);

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(mailFrom);
                mailMessage.To.Add(mailTo);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                client.Send(mailMessage);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
