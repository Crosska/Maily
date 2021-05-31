using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maily
{
    public class MailAccount
    {
        private string user_mail;
        private string user_password;
        private SmtpClient SMTPClient;
        private ImapClient IMAPClient;
        private bool SMTPSSL;
        private bool IMAPSSL;
        private bool active = false;

        public void active_set(bool active)
        {
            this.active = active;
        }

        public bool active_get()
        {
            return active;
        }

        public void SMTP_SSL_set(bool SSL)
        {
            SMTPSSL = SSL;
        }

        public void IMAP_SSL_set(bool SSL)
        {
            IMAPSSL = SSL;
        }

        public void user_mail_set(string user_mail)
        {
            this.user_mail = user_mail;
        }

        public void user_password_set(string user_password)
        {
            this.user_password = user_password;
        }

        public void SMTPClient_set(SmtpClient SMTPClient)
        {
            this.SMTPClient = SMTPClient;
        }

        public void IMAPClient_set(ImapClient IMAPClient)
        {
            this.IMAPClient = IMAPClient;
        }

        public bool SMTP_SSL_get()
        {
            return SMTPSSL;
        }

        public bool IMAP_SSL_get()
        {
            return IMAPSSL;
        }

        public string user_mail_get()
        {
            return user_mail;
        }

        public string user_password_get()
        {
            return user_password;
        }

        public SmtpClient SMTPClient_get()
        {
            return SMTPClient;
        }

        public ImapClient IMAPClient_get()
        {
            return IMAPClient;
        }
    }
}
