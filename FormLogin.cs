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

        public LoginForm()
        {
            InitializeComponent();
            checkBox_standart_settings.Checked = true;
        }

        private void checkBox_standart_settings_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_standart_settings.Checked)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            } else
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
            if (checkBox_standart_settings.Checked)
            {
                IMAP_Adress = "imap.gmail.com";
                IMAP_Port = 993;
                SMTP_Adress = "smtp.gmail.com";
                SMTP_Port = 465;
            } else
            {
                try
                {
                    IMAP_Adress = textBox_IMAP_adress.Text;
                    IMAP_Port = Convert.ToInt32(textBox_IMAP_port.Text);
                    SMTP_Adress = textBox_SMTP_adress.Text;
                    SMTP_Port = Convert.ToInt32(textBox_SMTP_port.Text);
                }
                catch (Exception ex)
                {
                    FormDialogWindow Dialog = new FormDialogWindow("Ошибка в данных", "Произошла ошибка при подготовке данных для подключения к серверам, проверьте правильность вводимых данных каждого из серверов.\n\n\n\n\n\n\n\n" + ex.StackTrace);
                    Dialog.ShowDialog();
                    return;
                }
            }

            try
            {
                ImapClient client_imap = new ImapClient();
                client_imap.Connect(IMAP_Adress, IMAP_Port, true);

                SmtpClient client_smtp = new SmtpClient();
                client_smtp.Connect(SMTP_Adress, SMTP_Port, true);

                try
                {
                    client_imap.Authenticate(textBox_mail_adress.Text, textBox_mail_password.Text);
                    client_smtp.Authenticate(textBox_mail_adress.Text, textBox_mail_password.Text);

                    FormMailbox MailBox = new FormMailbox(textBox_mail_adress.Text, client_imap, client_smtp);
                    this.Visible = false;
                    MailBox.ShowDialog();
                } catch (Exception ex)
                {
                    FormDialogWindow Dialog = new FormDialogWindow("Ошибка при входе в аккаунт", "Произошла ошибка при входе в аккаунт почты, проверьте введенную почту и пароль на наличие ошибок.\n\n\n\n\n\n\n\n" + ex.StackTrace);
                    Dialog.ShowDialog();
                }

            } catch (Exception ex)
            {
                FormDialogWindow Dialog = new FormDialogWindow("Ошибка при подключении к серверам", "Произошла ошибка при подключении к серверам почты, проверьте правильность вводимых данных каждого сервера.\n\n\n\n\n\n\n\n" + ex.StackTrace);
                Dialog.ShowDialog();
            }
           
        }
    }
}
