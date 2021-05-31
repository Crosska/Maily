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
    public partial class FormSettings : Form
    {

        string IMAP_Adress = "null";
        int IMAP_Port = 0;
        string SMTP_Adress = "null";
        int SMTP_Port = 0;
        bool IMAP_SSL = true;
        bool SMTP_SSL = true;

        public List<MailAccount> accounts;

        public FormSettings(List<MailAccount> accounts)
        {
            InitializeComponent();

            this.accounts = accounts;
            listbox_accounts.Items.Clear();
            for (int i = 0; i < accounts.Count; i++)
            {
                listbox_accounts.Items.Add(accounts[i].user_mail_get());
            }
        }

        private void checkBox_standart_settings_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_standart_settings.Checked)
            {
                groupBox_IMAP.Enabled = false;
                groupBox_SMTP.Enabled = false;
            }
            else
            {
                groupBox_IMAP.Enabled = true;
                groupBox_SMTP.Enabled = true;
            }

        }

        private void button_log_in_account_Click(object sender, EventArgs e)
        {
            try
            {
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
                    IMAP_Adress = textBox_IMAP_adress.Text;
                    IMAP_Port = Convert.ToInt32(textBox_IMAP_port.Text);
                    SMTP_Adress = textBox_SMTP_adress.Text;
                    SMTP_Port = Convert.ToInt32(textBox_SMTP_port.Text);
                    IMAP_SSL = checkBox_IMAP_SSL.Checked;
                    SMTP_SSL = checkBox_SMTP_SSL.Checked;
                }
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
            MailAccount new_account = new MailAccount();
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

                    new_account.IMAPClient_set(client_imap);
                    new_account.SMTPClient_set(client_smtp);
                    new_account.user_mail_set(textBox_mail_adress.Text);
                    new_account.user_password_set(textBox_mail_password.Text);
                    new_account.IMAP_SSL_set(IMAP_SSL);
                    new_account.SMTP_SSL_set(SMTP_SSL);

                    foreach (MailAccount acc in accounts)
                    {
                        if (acc.active_get())
                        {
                            acc.active_set(false);
                            break;
                        }
                    }

                    new_account.active_set(true);
                    accounts.Add(new_account);

                    DialogResult = DialogResult.OK;
                    Close();
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

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }

        private void button_change_accounts_Click(object sender, EventArgs e)
        {
            int index_for_rewrite = -1;

            MailAccount old_acc = new MailAccount();

            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].active_get())
                {
                    index_for_rewrite = i;
                    old_acc = accounts[i];
                    break;
                }
            }

            MailAccount new_acc = new MailAccount();
            new_acc.user_mail_set(old_acc.user_mail_get());
            new_acc.user_password_set(old_acc.user_password_get());

            try
            {
                ImapClient client_imap = new ImapClient();
                client_imap.Connect(textBox_IMAP_adress_change.Text, Convert.ToInt32(textBox_IMAP_port_change.Text), checkBox_IMAP_SSL_change.Checked);
                SmtpClient client_smtp = new SmtpClient();
                client_smtp.Connect(textBox_SMTP_adress_change.Text, Convert.ToInt32(textBox_SMTP_port_change.Text), checkBox_SMTP_SSL_change.Checked);
                try
                {
                    client_imap.Authenticate(old_acc.user_mail_get(), old_acc.user_password_get());
                    client_smtp.Authenticate(old_acc.user_mail_get(), old_acc.user_password_get());

                    new_acc.IMAPClient_set(client_imap);
                    new_acc.SMTPClient_set(client_smtp);
                    new_acc.IMAP_SSL_set(old_acc.IMAP_SSL_get());
                    new_acc.SMTP_SSL_set(old_acc.SMTP_SSL_get());
                    new_acc.active_set(true);

                    accounts[index_for_rewrite] = new_acc;

                    DialogResult = DialogResult.OK;
                    Close();
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

        private void button_delete_account_Click(object sender, EventArgs e)
        {
            if (listbox_accounts.SelectedIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта " + listbox_accounts.Items[listbox_accounts.SelectedIndex].ToString() + " ?",
                                              "Удаление аккаунта",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Information,
                                              MessageBoxDefaultButton.Button1,
                                              MessageBoxOptions.DefaultDesktopOnly);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < accounts.Count; i++)
                    {
                        if (accounts[i].user_mail_get().Equals(listbox_accounts.Items[listbox_accounts.SelectedIndex].ToString()))
                        {
                            accounts[i].IMAPClient_get().Disconnect(true);
                            accounts[i].SMTPClient_get().Disconnect(true);
                            accounts.RemoveAt(i);
                            if (accounts.Count == 0) Application.Exit();
                            else if (accounts.Count >= 1)
                            {
                                accounts[0].active_set(true);
                            }
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            else
            {
                MessageBox.Show(
                    "Выберите аккаунт для удаления из списка",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void button_switch_account_Click(object sender, EventArgs e)
        {
            int switch_index = listbox_accounts.SelectedIndex;
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].active_get())
                {
                    accounts[i].active_set(false);
                    accounts[switch_index].active_set(true);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

    }
}
