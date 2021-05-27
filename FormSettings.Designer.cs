
namespace Maily
{
    partial class FormSettings
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
            this.listbox_accounts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_mail_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_standart_settings = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_mail_adress = new System.Windows.Forms.TextBox();
            this.checkBox_SMTP_SSL = new System.Windows.Forms.CheckBox();
            this.textBox_SMTP_port = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_SMTP_adress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_IMAP_SSL = new System.Windows.Forms.CheckBox();
            this.textBox_IMAP_port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_IMAP_adress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbox_accounts
            // 
            this.listbox_accounts.FormattingEnabled = true;
            this.listbox_accounts.ItemHeight = 15;
            this.listbox_accounts.Location = new System.Drawing.Point(12, 27);
            this.listbox_accounts.Name = "listbox_accounts";
            this.listbox_accounts.Size = new System.Drawing.Size(184, 454);
            this.listbox_accounts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Аккаунты";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_standart_settings);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(202, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 472);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки текущего аккаунта";
            // 
            // textBox_mail_password
            // 
            this.textBox_mail_password.Location = new System.Drawing.Point(6, 90);
            this.textBox_mail_password.Name = "textBox_mail_password";
            this.textBox_mail_password.Size = new System.Drawing.Size(260, 23);
            this.textBox_mail_password.TabIndex = 4;
            this.textBox_mail_password.Text = "tempmailbox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Почта";
            // 
            // checkBox_standart_settings
            // 
            this.checkBox_standart_settings.AutoSize = true;
            this.checkBox_standart_settings.Checked = true;
            this.checkBox_standart_settings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_standart_settings.Location = new System.Drawing.Point(23, 158);
            this.checkBox_standart_settings.Name = "checkBox_standart_settings";
            this.checkBox_standart_settings.Size = new System.Drawing.Size(237, 19);
            this.checkBox_standart_settings.TabIndex = 19;
            this.checkBox_standart_settings.Text = "Использовать стандартные настройки";
            this.checkBox_standart_settings.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_mail_password);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_mail_adress);
            this.groupBox2.Location = new System.Drawing.Point(6, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 125);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные аккаунта";
            // 
            // textBox_mail_adress
            // 
            this.textBox_mail_adress.Location = new System.Drawing.Point(6, 46);
            this.textBox_mail_adress.Name = "textBox_mail_adress";
            this.textBox_mail_adress.Size = new System.Drawing.Size(260, 23);
            this.textBox_mail_adress.TabIndex = 2;
            this.textBox_mail_adress.Text = "temporary.mailbox.for.kurs@gmail.com";
            // 
            // checkBox_SMTP_SSL
            // 
            this.checkBox_SMTP_SSL.AutoSize = true;
            this.checkBox_SMTP_SSL.Location = new System.Drawing.Point(6, 115);
            this.checkBox_SMTP_SSL.Name = "checkBox_SMTP_SSL";
            this.checkBox_SMTP_SSL.Size = new System.Drawing.Size(227, 19);
            this.checkBox_SMTP_SSL.TabIndex = 11;
            this.checkBox_SMTP_SSL.Text = "Использование аутентификации SSL";
            this.checkBox_SMTP_SSL.UseVisualStyleBackColor = true;
            // 
            // textBox_SMTP_port
            // 
            this.textBox_SMTP_port.Location = new System.Drawing.Point(6, 83);
            this.textBox_SMTP_port.Name = "textBox_SMTP_port";
            this.textBox_SMTP_port.Size = new System.Drawing.Size(260, 23);
            this.textBox_SMTP_port.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Порт сервера";
            // 
            // textBox_SMTP_adress
            // 
            this.textBox_SMTP_adress.Location = new System.Drawing.Point(6, 39);
            this.textBox_SMTP_adress.Name = "textBox_SMTP_adress";
            this.textBox_SMTP_adress.Size = new System.Drawing.Size(260, 23);
            this.textBox_SMTP_adress.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Адрес сервера";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_SMTP_SSL);
            this.groupBox3.Controls.Add(this.textBox_SMTP_port);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_SMTP_adress);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(6, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 139);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные почтового сервера SMTP";
            // 
            // checkBox_IMAP_SSL
            // 
            this.checkBox_IMAP_SSL.AutoSize = true;
            this.checkBox_IMAP_SSL.Location = new System.Drawing.Point(6, 118);
            this.checkBox_IMAP_SSL.Name = "checkBox_IMAP_SSL";
            this.checkBox_IMAP_SSL.Size = new System.Drawing.Size(227, 19);
            this.checkBox_IMAP_SSL.TabIndex = 10;
            this.checkBox_IMAP_SSL.Text = "Использование аутентификации SSL";
            this.checkBox_IMAP_SSL.UseVisualStyleBackColor = true;
            // 
            // textBox_IMAP_port
            // 
            this.textBox_IMAP_port.Location = new System.Drawing.Point(6, 83);
            this.textBox_IMAP_port.Name = "textBox_IMAP_port";
            this.textBox_IMAP_port.Size = new System.Drawing.Size(260, 23);
            this.textBox_IMAP_port.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Порт сервера";
            // 
            // textBox_IMAP_adress
            // 
            this.textBox_IMAP_adress.Location = new System.Drawing.Point(6, 39);
            this.textBox_IMAP_adress.Name = "textBox_IMAP_adress";
            this.textBox_IMAP_adress.Size = new System.Drawing.Size(260, 23);
            this.textBox_IMAP_adress.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Адрес сервера";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_IMAP_SSL);
            this.groupBox4.Controls.Add(this.textBox_IMAP_port);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox_IMAP_adress);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(6, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 142);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Данные почтового сервера IMAP";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_accounts);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки Maily";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_accounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_standart_settings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_mail_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_mail_adress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_SMTP_SSL;
        private System.Windows.Forms.TextBox textBox_SMTP_port;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_SMTP_adress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox_IMAP_SSL;
        private System.Windows.Forms.TextBox textBox_IMAP_port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_IMAP_adress;
        private System.Windows.Forms.Label label5;
    }
}