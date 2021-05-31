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
        MimeMessage current_mail = new MimeMessage();
        WebBrowser webviewer = new WebBrowser();
        RichTextBox richtextbox = new RichTextBox();

        MailAccount current_account;

        IList<UniqueId> UIDS;
        List<MailAccount> accounts;

        bool mail_new = false;

        /// <summary>
        ///  Конструктор формы
        /// </summary>
        public FormMailbox(List<MailAccount> accounts)
        {
            InitializeComponent();

            this.accounts = accounts;
            current_account = find_active_account();
            current_account_mail.Text = current_account.user_mail_get();

            listbox_mail_boxes.SelectedIndex = 0;
            webviewer.Height = 225;
            webviewer.Width = 542;
            webviewer.Location = new Point(6, 129);
            groupBox3.Controls.Add(webviewer);
            richtextbox.Height = 225;
            richtextbox.Width = 542;
            richtextbox.Location = new Point(6, 129);
            groupBox3.Controls.Add(richtextbox);
        }

        private MailAccount find_active_account()
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].active_get()) return accounts[i];
            }
            return null;
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
            if (!mail_new)
            {
                textbox_receiver_mail.Clear();
                textbox_sender_mail.Clear();
                textbox_subject_mail.Clear();
                listbox_mail_in_box.Items.Clear();
                richtextbox.Clear();
                listboxt_attached_files.Items.Clear();
                string selected_mailbox = listbox_mail_boxes.SelectedItem.ToString(); // Сохранение выбранного названия раздела

                richtextbox.Clear(); // Очистка RichTextBox
                webviewer.Navigate(""); // Очистка WebBrowser

                if (selected_mailbox.Equals("Входящие"))
                {
                    selected_mailbox = "INBOX";
                    button_attach_new_file.Enabled = false;
                    button_delete_attached_files.Enabled = false;
                    button_download_attached_files.Enabled = true;
                    button_send_mail.Enabled = false;
                    button_delete_mail.Enabled = true;

                    richtextbox.Visible = false;
                    webviewer.Visible = true;
                }
                else
                {
                    switch (selected_mailbox)
                    {
                        case "Отправленные":
                            button_attach_new_file.Enabled = false;
                            button_delete_attached_files.Enabled = false;
                            button_download_attached_files.Enabled = true;
                            button_send_mail.Enabled = false;
                            button_delete_mail.Enabled = true;

                            richtextbox.Visible = false;
                            webviewer.Visible = true;
                            break;
                        case "Черновики":
                            button_attach_new_file.Enabled = true;
                            button_delete_attached_files.Enabled = true;
                            button_download_attached_files.Enabled = false;
                            button_send_mail.Enabled = true;
                            button_delete_mail.Enabled = true;

                            richtextbox.Visible = true;
                            webviewer.Visible = false;
                            break;
                        case "Корзина":
                            button_attach_new_file.Enabled = false;
                            button_delete_attached_files.Enabled = false;
                            button_download_attached_files.Enabled = false;
                            button_send_mail.Enabled = false;
                            button_delete_mail.Enabled = true;

                            richtextbox.Visible = false;
                            webviewer.Visible = true;
                            break;
                        case "Спам":
                            button_attach_new_file.Enabled = false;
                            button_delete_attached_files.Enabled = false;
                            button_download_attached_files.Enabled = false;
                            button_send_mail.Enabled = false;
                            button_delete_mail.Enabled = true;

                            webviewer.Visible = false;
                            richtextbox.Visible = false;
                            break;
                    }
                    selected_mailbox = "[Gmail]/" + selected_mailbox;
                }
                var folder = current_account.IMAPClient_get().GetFolder(selected_mailbox);
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
        }

        /// <summary>
        ///  Обработчик кнопки отправки письма
        /// </summary>
        private void button_send_mail_Click(object sender, EventArgs e)
        {
            mail_new = true;
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(textbox_sender_mail.Text));
            message.To.Add(new MailboxAddress(textbox_receiver_mail.Text));
            message.Subject = textbox_subject_mail.Text;
            var builder = new BodyBuilder();
            builder.HtmlBody = "<div>" + richtextbox.Text + "<div>";

            try
            {
                for (int i = 0; i < listboxt_attached_files.Items.Count; i++)
                {
                    builder.Attachments.Add((string)listboxt_attached_files.Items[i]);
                }
                message.Body = builder.ToMessageBody();
                current_account.SMTPClient_get().Send(message);

                textbox_receiver_mail.Clear();
                textbox_sender_mail.Text = current_account.user_mail_get();
                textbox_subject_mail.Clear();
                richtextbox.Clear();
                listboxt_attached_files.Items.Clear();

                mail_new = false;
                listbox_mail_boxes.SelectedIndex = 0;
            }
            catch (MailKit.CommandException)
            {
                MessageBox.Show(
                       "При попытке отправить письмо произошла ошибка, проверьте следующие параметры:\n - Почта получателя указана\n - Почта отправителя указана\n - Вес прикрепленных файлов не превышает лимит",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
            }
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
            var folder = current_account.IMAPClient_get().GetFolder(selected_mailbox);
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
            FormSettings settings = new FormSettings(accounts);

            var result = settings.ShowDialog();
            if (result == DialogResult.OK)
            {
                accounts = settings.accounts;
                current_account = find_active_account();
                if (current_account == null) Application.Exit();
                current_account_mail.Text = current_account.user_mail_get();
                listbox_mail_boxes.SelectedIndex = 1;
                listbox_mail_boxes.SelectedIndex = 0;

            }
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
            button_attach_new_file.Enabled = true;
            button_delete_attached_files.Enabled = true;
            button_download_attached_files.Enabled = false;
            button_send_mail.Enabled = true;
            button_delete_mail.Enabled = false;

            mail_new = true;
            textbox_receiver_mail.Clear();
            textbox_sender_mail.Text = current_account.user_mail_get();
            textbox_subject_mail.Clear();
            listbox_mail_in_box.Items.Clear();
            try { listbox_mail_boxes.SetSelected(listbox_mail_boxes.SelectedIndex, false); }
            catch { }
            webviewer.Visible = false;
            richtextbox.Visible = true;
            richtextbox.Clear();
            listboxt_attached_files.Items.Clear();
            mail_new = false;
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
                MessageBox.Show(
                        "Предупреждение",
                        "Сохранение вложений было отклонено.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
            }
            else
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

                MessageBox.Show(
                       "Выполнено",
                       "Файлы были успешно сохранены по выбранному вами пути\nПуть: " + path,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        /// <summary>
        ///  Обработчик события загрузки формы
        /// </summary>
        private void FormMailbox_Load(object sender, EventArgs e)
        {

        }

        private void button_attach_new_file_Click(object sender, EventArgs e)
        {
            string path = "null";
            using (var ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }

            }
            if (path.Equals("null"))
            {
                MessageBox.Show(
                        "Прикрепление файла было отменено",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                listboxt_attached_files.Items.Add(path);

                MessageBox.Show(
                       "Файл был успешно прикреплен\nПуть: " + path,
                       "Выполнено",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void button_delete_attached_files_Click(object sender, EventArgs e)
        {
            try
            {
                listboxt_attached_files.Items.RemoveAt(listboxt_attached_files.SelectedIndex);
            }
            catch (Exception)
            {
                MessageBox.Show(
                       "Сначала выберите прикрепленный файл из списка",
                       "Предупреждение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void button_delete_mail_Click(object sender, EventArgs e)
        {
            if (listbox_mail_in_box.SelectedIndex >= 0)
            {
                if (listbox_mail_boxes.SelectedItem.ToString().Equals("Черновики"))
                {
                    DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить навсегда данное письмо?",
                                           "Удаление письма",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Information,
                                           MessageBoxDefaultButton.Button1,
                                           MessageBoxOptions.DefaultDesktopOnly);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string selected_mailbox = listbox_mail_boxes.SelectedItem.ToString(); // Сохранение выбранного названия раздела
                        selected_mailbox = "[Gmail]/" + selected_mailbox;
                        var folder = current_account.IMAPClient_get().GetFolder(selected_mailbox);
                        folder.Open(FolderAccess.ReadWrite);
                        IList<UniqueId> UIDS = new List<UniqueId>() { folder.Search(SearchQuery.All)[listbox_mail_in_box.SelectedIndex] };
                        folder.AddFlags(listbox_mail_in_box.SelectedIndex, MessageFlags.Deleted, true);

                        folder.Expunge();
                        folder.Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите переместить письмо в корзину?",
                                           "Отправка письма в корзину",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Information,
                                           MessageBoxDefaultButton.Button1,
                                           MessageBoxOptions.DefaultDesktopOnly);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string selected_mailbox = listbox_mail_boxes.SelectedItem.ToString(); // Сохранение выбранного названия раздела
                        if (selected_mailbox.Equals("Входящие"))
                        {
                            selected_mailbox = "INBOX";
                        }
                        else
                        {
                            selected_mailbox = "[Gmail]/" + selected_mailbox;
                        }

                        var folder = current_account.IMAPClient_get().GetFolder(selected_mailbox);
                        var folder_destination = current_account.IMAPClient_get().GetFolder("[Gmail]/Черновики");
                        folder.Open(FolderAccess.ReadWrite);
                        UniqueId UID = folder.Search(SearchQuery.All)[listbox_mail_in_box.SelectedIndex];
                        folder.MoveTo(UID, folder_destination);
                        folder.Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show(
                       "Сначала выберите какое-либо письмо из списка",
                       "Предупреждение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
