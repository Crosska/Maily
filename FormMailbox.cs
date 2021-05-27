using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Maily
{

    public partial class FormMailbox : Form
    {
        ImapClient current_client_imap;
        SmtpClient current_client_smtp;
        MimeMessage current_mail = new MimeMessage();
        WebBrowser webviewer = new WebBrowser();

        MailAccount current_account;

        IList<UniqueId> UIDS;

        bool mail_sendable = false;

        /// <summary>
        ///  Конструктор формы
        /// </summary>
        public FormMailbox(string client_mail, ImapClient client_imap, SmtpClient client_smtp)
        {
            InitializeComponent();
            current_account = new MailAccount();
            current_account.IMAPClient_set(client_imap);
            current_account.SMTPClient_set(client_smtp);
            current_account.user_mail_set(client_mail);

            current_account_mail.Text = current_account.user_mail_get();
            listbox_mail_boxes.SelectedIndex = 0;

            webviewer.Height = 225;
            webviewer.Width = 542;
            webviewer.Location = new Point(6, 129);
            groupBox3.Controls.Add(webviewer);

        }

        /// <summary>
        ///  Обработчик события закрытия формы
        /// </summary>
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  Обработчик списка вывода писем выбранного раздела почты
        /// </summary>
        private void listbox_mailboxes_selected_item_changed(object sender, EventArgs e)
        {
            listbox_mail_in_box.Items.Clear(); // Очистка списка сообщений раздела
            string selected_mailbox = listbox_mail_boxes.SelectedItem.ToString(); // Сохранение выбранного названия раздела
            if (selected_mailbox.Equals("Входящие"))
            {
                selected_mailbox = "INBOX";
                button_attach_new_file.Enabled = false;
                button_delete_attached_files.Enabled = false;
                button_download_attached_files.Enabled = true;
                button_send_mail.Enabled = false;
            }
            else
            {
                selected_mailbox = "[Gmail]/" + selected_mailbox;
                switch (selected_mailbox)
                {
                    case "Отправленные":
                        button_attach_new_file.Enabled = false;
                        button_delete_attached_files.Enabled = false;
                        button_download_attached_files.Enabled = true;
                        button_send_mail.Enabled = false;
                        break;
                    case "Черновики":
                        button_attach_new_file.Enabled = true;
                        button_delete_attached_files.Enabled = true;
                        button_download_attached_files.Enabled = false;
                        button_send_mail.Enabled = true;
                        break;
                    case "Корзина":
                        button_attach_new_file.Enabled = false;
                        button_delete_attached_files.Enabled = false;
                        button_download_attached_files.Enabled = false;
                        button_send_mail.Enabled = false;
                        break;
                    case "Спам":
                        button_attach_new_file.Enabled = false;
                        button_delete_attached_files.Enabled = false;
                        button_download_attached_files.Enabled = false;
                        button_send_mail.Enabled = false;
                        break;
                }
            }
            var folder = current_client_imap.GetFolder(selected_mailbox);
            folder.Open(FolderAccess.ReadWrite);
            UIDS = folder.Search(SearchQuery.All);
            List<MimeMessage> currentMails = new List<MimeMessage>(UIDS.Count);
            foreach (UniqueId UID in UIDS)
            {
                MimeMessage mail = folder.GetMessage(UID);
                currentMails.Insert(0, mail);
                listbox_mail_in_box.Items.Add(mail.Subject);
            }
            folder.Close();
        }

        /// <summary>
        ///  Обработчик кнопки отправки письма
        /// </summary>
        private void button_send_mail_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        ///  Обработчик списка вывода данных о выбранном письме
        /// </summary>
        private void listbox_selected_mail_changed(object sender, EventArgs e)
        {
            UniqueId selected_mail_id = UIDS[listbox_mail_in_box.SelectedIndex];

            string selected_mailbox = listbox_mail_boxes.SelectedItem.ToString(); // Сохранение выбранного названия раздела
            if (selected_mailbox.Equals("Входящие"))
            {
                selected_mailbox = "INBOX";
            }
            else
            {
                selected_mailbox = "[Gmail]/" + selected_mailbox;
            }
            var folder = current_client_imap.GetFolder(selected_mailbox);
            folder.Open(FolderAccess.ReadWrite);
            UIDS = folder.Search(SearchQuery.All);
            List<MimeMessage> currentMails = new List<MimeMessage>(UIDS.Count);
            MimeMessage mail = folder.GetMessage(selected_mail_id);
            current_mail = mail;
            folder.Close();

            textbox_receiver_mail.Text = mail.To.ToString();
            textbox_sender_mail.Text = mail.From.ToString();
            textbox_subject_mail.Text = mail.Subject.ToString();
            webviewer.DocumentText = mail.HtmlBody;

            listboxt_attached_files.Items.Clear(); // Очистка списка сообщений раздела
            foreach (var attachment in mail.Attachments)
            {
                var fileName = attachment.ContentDisposition?.FileName ?? attachment.ContentType.Name;
                listboxt_attached_files.Items.Add(fileName);
            }

        }

        /// <summary>
        ///  Обработчик кнопки вывода информации о программе
        /// </summary>
        private void button_program_description_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///  Обработчик кнопки создания нового письма
        /// </summary>
        private void button_mailbox_settings_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///  Обработчик кнопки обновления почты
        /// </summary>
        private void button_refresh_mailbox_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///  Обработчик кнопки создания нового письма
        /// </summary>
        private void button_create_new_mail_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        ///  Обработчик кнопки сохранения прикрепленных файлов
        /// </summary>
        private void button_download_attached_files_Click(object sender, EventArgs e)
        {

            string path = "null";
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    path = Path.GetFullPath(fbd.SelectedPath);
                }
            }
            if (path.Equals("null"))
            {
                FormDialogWindow dialog_form = new FormDialogWindow("Сохранение файлов", "Сохранение вложений было отклонено вами.");
                dialog_form.ShowDialog();
            } else
            {
                foreach (var attachment in current_mail.Attachments)
                {
                    var fileName = attachment.ContentDisposition?.FileName ?? attachment.ContentType.Name;
                    using (var stream = File.Create(path + "\\" + fileName))
                    {
                        if (attachment is MessagePart)
                        {
                            var rfc822 = (MessagePart)attachment;
                            rfc822.Message.WriteTo(stream);
                        }
                        else
                        {
                            var part = (MimePart)attachment;
                            part.Content.DecodeTo(stream);
                        }
                    }
                }

                FormDialogWindow dialog_form = new FormDialogWindow("Сохранение файлов", "Файлы успешно сохранены по пути: \" " + path + " \"");
                dialog_form.ShowDialog();
            }
        }

        private void FormMailbox_Load(object sender, EventArgs e)
        {

        }
    }
}
