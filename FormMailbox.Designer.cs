
namespace Maily
{
    partial class FormMailbox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listbox_mail_boxes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusstrip = new System.Windows.Forms.StatusStrip();
            this.current_account_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.current_account_mail = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listbox_mail_in_box = new System.Windows.Forms.ListBox();
            this.button_create_new_mail = new System.Windows.Forms.Button();
            this.button_refresh_mailbox = new System.Windows.Forms.Button();
            this.button_mailbox_settings = new System.Windows.Forms.Button();
            this.button_program_description = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_send_mail = new System.Windows.Forms.Button();
            this.button_attach_new_file = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listboxt_attached_files = new System.Windows.Forms.ListBox();
            this.button_delete_attached_files = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_download_attached_files = new System.Windows.Forms.Button();
            this.textbox_subject_mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_receiver_mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_sender_mail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.statusstrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbox_mail_boxes
            // 
            this.listbox_mail_boxes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listbox_mail_boxes.FormattingEnabled = true;
            this.listbox_mail_boxes.ItemHeight = 30;
            this.listbox_mail_boxes.Items.AddRange(new object[] {
            "Входящие",
            "Отправленные",
            "Черновики",
            "Корзина",
            "Спам"});
            this.listbox_mail_boxes.Location = new System.Drawing.Point(6, 22);
            this.listbox_mail_boxes.Name = "listbox_mail_boxes";
            this.listbox_mail_boxes.Size = new System.Drawing.Size(188, 484);
            this.listbox_mail_boxes.TabIndex = 0;
            this.listbox_mail_boxes.SelectedIndexChanged += new System.EventHandler(this.listbox_mailboxes_selected_item_changed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listbox_mail_boxes);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 513);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Разделы почты";
            // 
            // statusstrip
            // 
            this.statusstrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusstrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.current_account_label,
            this.current_account_mail});
            this.statusstrip.Location = new System.Drawing.Point(0, 558);
            this.statusstrip.Name = "statusstrip";
            this.statusstrip.Size = new System.Drawing.Size(992, 30);
            this.statusstrip.TabIndex = 4;
            this.statusstrip.Text = "statusstrip";
            // 
            // current_account_label
            // 
            this.current_account_label.Name = "current_account_label";
            this.current_account_label.Size = new System.Drawing.Size(136, 25);
            this.current_account_label.Text = "Текущий аккаунт:";
            // 
            // current_account_mail
            // 
            this.current_account_mail.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.current_account_mail.Name = "current_account_mail";
            this.current_account_mail.Size = new System.Drawing.Size(179, 25);
            this.current_account_mail.Text = "tool_strip_acount_name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listbox_mail_in_box);
            this.groupBox2.Location = new System.Drawing.Point(775, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 513);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Письма в разделе";
            // 
            // listbox_mail_in_box
            // 
            this.listbox_mail_in_box.BackColor = System.Drawing.SystemColors.Control;
            this.listbox_mail_in_box.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listbox_mail_in_box.FormattingEnabled = true;
            this.listbox_mail_in_box.HorizontalScrollbar = true;
            this.listbox_mail_in_box.Location = new System.Drawing.Point(6, 22);
            this.listbox_mail_in_box.Name = "listbox_mail_in_box";
            this.listbox_mail_in_box.Size = new System.Drawing.Size(199, 485);
            this.listbox_mail_in_box.TabIndex = 0;
            this.listbox_mail_in_box.SelectedIndexChanged += new System.EventHandler(this.listbox_selected_mail_changed);
            // 
            // button_create_new_mail
            // 
            this.button_create_new_mail.BackColor = System.Drawing.SystemColors.Control;
            this.button_create_new_mail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_create_new_mail.Location = new System.Drawing.Point(12, 12);
            this.button_create_new_mail.Name = "button_create_new_mail";
            this.button_create_new_mail.Size = new System.Drawing.Size(209, 30);
            this.button_create_new_mail.TabIndex = 6;
            this.button_create_new_mail.Text = "Создать новое письмо";
            this.button_create_new_mail.UseVisualStyleBackColor = false;
            this.button_create_new_mail.Click += new System.EventHandler(this.button_create_new_mail_Click);
            // 
            // button_refresh_mailbox
            // 
            this.button_refresh_mailbox.BackColor = System.Drawing.SystemColors.Control;
            this.button_refresh_mailbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_refresh_mailbox.Location = new System.Drawing.Point(227, 12);
            this.button_refresh_mailbox.Name = "button_refresh_mailbox";
            this.button_refresh_mailbox.Size = new System.Drawing.Size(193, 30);
            this.button_refresh_mailbox.TabIndex = 7;
            this.button_refresh_mailbox.Text = "Обновить почту";
            this.button_refresh_mailbox.UseVisualStyleBackColor = false;
            this.button_refresh_mailbox.Click += new System.EventHandler(this.button_refresh_mailbox_Click);
            // 
            // button_mailbox_settings
            // 
            this.button_mailbox_settings.BackColor = System.Drawing.SystemColors.Control;
            this.button_mailbox_settings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_mailbox_settings.Location = new System.Drawing.Point(426, 12);
            this.button_mailbox_settings.Name = "button_mailbox_settings";
            this.button_mailbox_settings.Size = new System.Drawing.Size(200, 30);
            this.button_mailbox_settings.TabIndex = 8;
            this.button_mailbox_settings.Text = "Настройки почты";
            this.button_mailbox_settings.UseVisualStyleBackColor = false;
            this.button_mailbox_settings.Click += new System.EventHandler(this.button_mailbox_settings_Click);
            // 
            // button_program_description
            // 
            this.button_program_description.BackColor = System.Drawing.SystemColors.Control;
            this.button_program_description.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_program_description.Location = new System.Drawing.Point(632, 12);
            this.button_program_description.Name = "button_program_description";
            this.button_program_description.Size = new System.Drawing.Size(348, 30);
            this.button_program_description.TabIndex = 9;
            this.button_program_description.Text = "Сведения о программе";
            this.button_program_description.UseVisualStyleBackColor = false;
            this.button_program_description.Click += new System.EventHandler(this.button_program_description_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_send_mail);
            this.groupBox3.Controls.Add(this.button_attach_new_file);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.listboxt_attached_files);
            this.groupBox3.Controls.Add(this.button_delete_attached_files);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button_download_attached_files);
            this.groupBox3.Controls.Add(this.textbox_subject_mail);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textbox_receiver_mail);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textbox_sender_mail);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(218, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 506);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные письма";
            // 
            // button_send_mail
            // 
            this.button_send_mail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_send_mail.Location = new System.Drawing.Point(6, 464);
            this.button_send_mail.Name = "button_send_mail";
            this.button_send_mail.Size = new System.Drawing.Size(545, 36);
            this.button_send_mail.TabIndex = 17;
            this.button_send_mail.Text = "Отправить";
            this.button_send_mail.UseVisualStyleBackColor = true;
            this.button_send_mail.Click += new System.EventHandler(this.button_send_mail_Click);
            // 
            // button_attach_new_file
            // 
            this.button_attach_new_file.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_attach_new_file.Location = new System.Drawing.Point(443, 430);
            this.button_attach_new_file.Name = "button_attach_new_file";
            this.button_attach_new_file.Size = new System.Drawing.Size(108, 31);
            this.button_attach_new_file.TabIndex = 16;
            this.button_attach_new_file.Text = "Прикрепить";
            this.button_attach_new_file.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Прикрепленные файлы";
            // 
            // listboxt_attached_files
            // 
            this.listboxt_attached_files.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listboxt_attached_files.FormattingEnabled = true;
            this.listboxt_attached_files.Location = new System.Drawing.Point(6, 376);
            this.listboxt_attached_files.Name = "listboxt_attached_files";
            this.listboxt_attached_files.Size = new System.Drawing.Size(431, 82);
            this.listboxt_attached_files.TabIndex = 12;
            // 
            // button_delete_attached_files
            // 
            this.button_delete_attached_files.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete_attached_files.Location = new System.Drawing.Point(443, 398);
            this.button_delete_attached_files.Name = "button_delete_attached_files";
            this.button_delete_attached_files.Size = new System.Drawing.Size(108, 31);
            this.button_delete_attached_files.TabIndex = 15;
            this.button_delete_attached_files.Text = "Открепить";
            this.button_delete_attached_files.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Содержимое письма";
            // 
            // button_download_attached_files
            // 
            this.button_download_attached_files.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_download_attached_files.Location = new System.Drawing.Point(443, 366);
            this.button_download_attached_files.Name = "button_download_attached_files";
            this.button_download_attached_files.Size = new System.Drawing.Size(108, 31);
            this.button_download_attached_files.TabIndex = 14;
            this.button_download_attached_files.Text = "Скачать";
            this.button_download_attached_files.UseVisualStyleBackColor = true;
            this.button_download_attached_files.Click += new System.EventHandler(this.button_download_attached_files_Click);
            // 
            // textbox_subject_mail
            // 
            this.textbox_subject_mail.Location = new System.Drawing.Point(125, 80);
            this.textbox_subject_mail.Name = "textbox_subject_mail";
            this.textbox_subject_mail.Size = new System.Drawing.Size(426, 23);
            this.textbox_subject_mail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тема письма";
            // 
            // textbox_receiver_mail
            // 
            this.textbox_receiver_mail.Location = new System.Drawing.Point(125, 51);
            this.textbox_receiver_mail.Name = "textbox_receiver_mail";
            this.textbox_receiver_mail.Size = new System.Drawing.Size(426, 23);
            this.textbox_receiver_mail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Почта получателя";
            // 
            // textbox_sender_mail
            // 
            this.textbox_sender_mail.Location = new System.Drawing.Point(125, 22);
            this.textbox_sender_mail.Name = "textbox_sender_mail";
            this.textbox_sender_mail.Size = new System.Drawing.Size(426, 23);
            this.textbox_sender_mail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Почта отправителя";
            // 
            // FormMailbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 588);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_program_description);
            this.Controls.Add(this.button_mailbox_settings);
            this.Controls.Add(this.button_refresh_mailbox);
            this.Controls.Add(this.button_create_new_mail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusstrip);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMailbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maily";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.Load += new System.EventHandler(this.FormMailbox_Load);
            this.groupBox1.ResumeLayout(false);
            this.statusstrip.ResumeLayout(false);
            this.statusstrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_mail_boxes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusstrip;
        private System.Windows.Forms.ToolStripStatusLabel current_account_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listbox_mail_in_box;
        private System.Windows.Forms.Button button_create_new_mail;
        private System.Windows.Forms.Button button_refresh_mailbox;
        private System.Windows.Forms.Button button_mailbox_settings;
        private System.Windows.Forms.Button button_program_description;
        private System.Windows.Forms.ToolStripStatusLabel current_account_mail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_delete_attached_files;
        private System.Windows.Forms.Button button_download_attached_files;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listboxt_attached_files;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_subject_mail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_receiver_mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_sender_mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_send_mail;
        private System.Windows.Forms.Button button_attach_new_file;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}