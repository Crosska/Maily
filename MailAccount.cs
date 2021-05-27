using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maily
{
    class MailAccount
    {
        private string user_mail;
        private SmtpClient SMTPClient;
        private ImapClient IMAPClient;
        private bool SMTPSSL;
        private bool IMAPSSL;

        public void SMTP_SSL_set(bool SSL)
        {
            SMTPSSl = SSL;
        }

        public void IMAP_SSL_set(bool SSL)
        {
            SMTPSSl = SSL;
        }

        public void user_mail_set(string user_mail)
        {
            this.user_mail = user_mail;
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
