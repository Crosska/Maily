using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maily
{

    public partial class LoginForm : Form
    {

        string IMAP_Adress = "null";
        int IMAP_Port = 0;
        string SMTP_Adress = "null";
        int SMTP_Port = 0;
        bool IMAP_SSL = true;
        bool SMTP_SSL = true;

        public LoginForm()
        {
            InitializeComponent();
            checkBox_standart_settings.Checked = true;
        }

        private void checkBox_standart_settings_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_standart_settings.Checked)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Log_In_Click(object sender, EventArgs e)
        {
            List<MailAccount> account_list = new List<MailAccount>();
            MailAccount new_acc = new MailAccount();

            if (checkBox_standart_settings.Checked)
            {
                IMAP_Adress = "imap.gmail.com";
                IMAP_Port = 993;
                SMTP_Adress = "smtp.gmail.com";
                SMTP_Port = 465;
                IMAP_SSL = true;
                SMTP_SSL = true;
            }
            else
            {
                try
                {
                    IMAP_Adress = textBox_IMAP_adress.Text;
                    IMAP_Port = Convert.ToInt32(textBox_IMAP_port.Text);
                    SMTP_Adress = textBox_SMTP_adress.Text;
                    SMTP_Port = Convert.ToInt32(textBox_SMTP_port.Text);
                    IMAP_SSL = checkBox_IMAP_SSL.Checked;
                    SMTP_SSL = checkBox_SMTP_SSL.Checked;
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "Произошла ошибка при подготовке данных для подключения к серверам, проверьте правильность вводимых данных каждого из серверов.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }
            }

            try
            {

                ImapClient client_imap = new ImapClient();
                client_imap.Connect(IMAP_Adress, IMAP_Port, IMAP_SSL);

                SmtpClient client_smtp = new SmtpClient();
                client_smtp.Connect(SMTP_Adress, SMTP_Port, SMTP_SSL);

                try
                {
                    client_imap.Authenticate(textBox_mail_adress.Text, textBox_mail_password.Text);
                    client_smtp.Authenticate(textBox_mail_adress.Text, textBox_mail_password.Text);

                    new_acc.IMAPClient_set(client_imap);
                    new_acc.SMTPClient_set(client_smtp);
                    new_acc.user_mail_set(textBox_mail_adress.Text);
                    new_acc.user_password_set(textBox_mail_password.Text);
                    new_acc.IMAP_SSL_set(IMAP_SSL);
                    new_acc.SMTP_SSL_set(SMTP_SSL);
                    new_acc.active_set(true);
                    account_list.Add(new_acc);

                    FormMailbox MailBox = new FormMailbox(account_list);
                    this.Visible = false;
                    MailBox.ShowDialog();
                }
                catch (MailKit.ServiceNotAuthenticatedException)
                {
                    MessageBox.Show(
                    "Произошла ошибка при входе в аккаунт почты, проверьте введенную почту и пароль на наличие ошибок.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }

            }
            catch (MailKit.ServiceNotConnectedException)
            {
                MessageBox.Show(
                    "Произошла ошибка при подключении к серверам почты, проверьте правильность вводимых данных каждого сервера.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }

        }
    }
}
