
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_log_in_account = new System.Windows.Forms.Button();
            this.checkBox_standart_settings = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_mail_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_mail_adress = new System.Windows.Forms.TextBox();
            this.groupBox_SMTP = new System.Windows.Forms.GroupBox();
            this.checkBox_SMTP_SSL = new System.Windows.Forms.CheckBox();
            this.textBox_SMTP_port = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_SMTP_adress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_IMAP = new System.Windows.Forms.GroupBox();
            this.checkBox_IMAP_SSL = new System.Windows.Forms.CheckBox();
            this.textBox_IMAP_port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_IMAP_adress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_delete_account = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button_change_accounts = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBox_SMTP_SSL_change = new System.Windows.Forms.CheckBox();
            this.textBox_SMTP_port_change = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_SMTP_adress_change = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.checkBox_IMAP_SSL_change = new System.Windows.Forms.CheckBox();
            this.textBox_IMAP_port_change = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_IMAP_adress_change = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_switch_account = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_SMTP.SuspendLayout();
            this.groupBox_IMAP.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbox_accounts
            // 
            this.listbox_accounts.FormattingEnabled = true;
            this.listbox_accounts.ItemHeight = 15;
            this.listbox_accounts.Location = new System.Drawing.Point(6, 22);
            this.listbox_accounts.Name = "listbox_accounts";
            this.listbox_accounts.Size = new System.Drawing.Size(229, 379);
            this.listbox_accounts.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_log_in_account);
            this.groupBox1.Controls.Add(this.checkBox_standart_settings);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox_SMTP);
            this.groupBox1.Controls.Add(this.groupBox_IMAP);
            this.groupBox1.Location = new System.Drawing.Point(259, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 538);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить новый аккаунт";
            // 
            // button_log_in_account
            // 
            this.button_log_in_account.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_log_in_account.Location = new System.Drawing.Point(6, 476);
            this.button_log_in_account.Name = "button_log_in_account";
            this.button_log_in_account.Size = new System.Drawing.Size(272, 56);
            this.button_log_in_account.TabIndex = 20;
            this.button_log_in_account.Text = "Войти в новый аккаунт";
            this.button_log_in_account.UseVisualStyleBackColor = true;
            this.button_log_in_account.Click += new System.EventHandler(this.button_log_in_account_Click);
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
            this.checkBox_standart_settings.CheckedChanged += new System.EventHandler(this.checkBox_standart_settings_CheckedChanged);
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
            // textBox_mail_password
            // 
            this.textBox_mail_password.Location = new System.Drawing.Point(6, 90);
            this.textBox_mail_password.Name = "textBox_mail_password";
            this.textBox_mail_password.PasswordChar = '*';
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
            // textBox_mail_adress
            // 
            this.textBox_mail_adress.Location = new System.Drawing.Point(6, 46);
            this.textBox_mail_adress.Name = "textBox_mail_adress";
            this.textBox_mail_adress.Size = new System.Drawing.Size(260, 23);
            this.textBox_mail_adress.TabIndex = 2;
            this.textBox_mail_adress.Text = "temporary.mailbox.for.kurs@gmail.com";
            // 
            // groupBox_SMTP
            // 
            this.groupBox_SMTP.Controls.Add(this.checkBox_SMTP_SSL);
            this.groupBox_SMTP.Controls.Add(this.textBox_SMTP_port);
            this.groupBox_SMTP.Controls.Add(this.label7);
            this.groupBox_SMTP.Controls.Add(this.textBox_SMTP_adress);
            this.groupBox_SMTP.Controls.Add(this.label8);
            this.groupBox_SMTP.Enabled = false;
            this.groupBox_SMTP.Location = new System.Drawing.Point(6, 331);
            this.groupBox_SMTP.Name = "groupBox_SMTP";
            this.groupBox_SMTP.Size = new System.Drawing.Size(272, 139);
            this.groupBox_SMTP.TabIndex = 18;
            this.groupBox_SMTP.TabStop = false;
            this.groupBox_SMTP.Text = "Данные почтового сервера SMTP";
            // 
            // checkBox_SMTP_SSL
            // 
            this.checkBox_SMTP_SSL.AutoSize = true;
            this.checkBox_SMTP_SSL.Checked = true;
            this.checkBox_SMTP_SSL.CheckState = System.Windows.Forms.CheckState.Checked;
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
            // groupBox_IMAP
            // 
            this.groupBox_IMAP.Controls.Add(this.checkBox_IMAP_SSL);
            this.groupBox_IMAP.Controls.Add(this.textBox_IMAP_port);
            this.groupBox_IMAP.Controls.Add(this.label4);
            this.groupBox_IMAP.Controls.Add(this.textBox_IMAP_adress);
            this.groupBox_IMAP.Controls.Add(this.label5);
            this.groupBox_IMAP.Enabled = false;
            this.groupBox_IMAP.Location = new System.Drawing.Point(6, 183);
            this.groupBox_IMAP.Name = "groupBox_IMAP";
            this.groupBox_IMAP.Size = new System.Drawing.Size(272, 142);
            this.groupBox_IMAP.TabIndex = 17;
            this.groupBox_IMAP.TabStop = false;
            this.groupBox_IMAP.Text = "Данные почтового сервера IMAP";
            // 
            // checkBox_IMAP_SSL
            // 
            this.checkBox_IMAP_SSL.AutoSize = true;
            this.checkBox_IMAP_SSL.Checked = true;
            this.checkBox_IMAP_SSL.CheckState = System.Windows.Forms.CheckState.Checked;
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_switch_account);
            this.groupBox5.Controls.Add(this.button_delete_account);
            this.groupBox5.Controls.Add(this.listbox_accounts);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(241, 538);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Список аккаунтов";
            // 
            // button_delete_account
            // 
            this.button_delete_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_delete_account.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete_account.Location = new System.Drawing.Point(6, 476);
            this.button_delete_account.Name = "button_delete_account";
            this.button_delete_account.Size = new System.Drawing.Size(229, 56);
            this.button_delete_account.TabIndex = 21;
            this.button_delete_account.Text = "Удалить выбранный";
            this.button_delete_account.UseVisualStyleBackColor = false;
            this.button_delete_account.Click += new System.EventHandler(this.button_delete_account_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_change_accounts);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Location = new System.Drawing.Point(553, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(295, 378);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Изменить параметры";
            // 
            // button_change_accounts
            // 
            this.button_change_accounts.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_change_accounts.Location = new System.Drawing.Point(10, 315);
            this.button_change_accounts.Name = "button_change_accounts";
            this.button_change_accounts.Size = new System.Drawing.Size(272, 52);
            this.button_change_accounts.TabIndex = 20;
            this.button_change_accounts.Text = "Изменить параметры";
            this.button_change_accounts.UseVisualStyleBackColor = true;
            this.button_change_accounts.Click += new System.EventHandler(this.button_change_accounts_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBox_SMTP_SSL_change);
            this.groupBox8.Controls.Add(this.textBox_SMTP_port_change);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.textBox_SMTP_adress_change);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Location = new System.Drawing.Point(10, 170);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(272, 139);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Данные почтового сервера SMTP";
            // 
            // checkBox_SMTP_SSL_change
            // 
            this.checkBox_SMTP_SSL_change.AutoSize = true;
            this.checkBox_SMTP_SSL_change.Checked = true;
            this.checkBox_SMTP_SSL_change.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SMTP_SSL_change.Location = new System.Drawing.Point(6, 115);
            this.checkBox_SMTP_SSL_change.Name = "checkBox_SMTP_SSL_change";
            this.checkBox_SMTP_SSL_change.Size = new System.Drawing.Size(227, 19);
            this.checkBox_SMTP_SSL_change.TabIndex = 11;
            this.checkBox_SMTP_SSL_change.Text = "Использование аутентификации SSL";
            this.checkBox_SMTP_SSL_change.UseVisualStyleBackColor = true;
            // 
            // textBox_SMTP_port_change
            // 
            this.textBox_SMTP_port_change.Location = new System.Drawing.Point(6, 83);
            this.textBox_SMTP_port_change.Name = "textBox_SMTP_port_change";
            this.textBox_SMTP_port_change.Size = new System.Drawing.Size(260, 23);
            this.textBox_SMTP_port_change.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Порт сервера";
            // 
            // textBox_SMTP_adress_change
            // 
            this.textBox_SMTP_adress_change.Location = new System.Drawing.Point(6, 39);
            this.textBox_SMTP_adress_change.Name = "textBox_SMTP_adress_change";
            this.textBox_SMTP_adress_change.Size = new System.Drawing.Size(260, 23);
            this.textBox_SMTP_adress_change.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Адрес сервера";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.checkBox_IMAP_SSL_change);
            this.groupBox9.Controls.Add(this.textBox_IMAP_port_change);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.textBox_IMAP_adress_change);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Location = new System.Drawing.Point(10, 22);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(272, 142);
            this.groupBox9.TabIndex = 17;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Данные почтового сервера IMAP";
            // 
            // checkBox_IMAP_SSL_change
            // 
            this.checkBox_IMAP_SSL_change.AutoSize = true;
            this.checkBox_IMAP_SSL_change.Checked = true;
            this.checkBox_IMAP_SSL_change.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_IMAP_SSL_change.Location = new System.Drawing.Point(6, 118);
            this.checkBox_IMAP_SSL_change.Name = "checkBox_IMAP_SSL_change";
            this.checkBox_IMAP_SSL_change.Size = new System.Drawing.Size(227, 19);
            this.checkBox_IMAP_SSL_change.TabIndex = 10;
            this.checkBox_IMAP_SSL_change.Text = "Использование аутентификации SSL";
            this.checkBox_IMAP_SSL_change.UseVisualStyleBackColor = true;
            // 
            // textBox_IMAP_port_change
            // 
            this.textBox_IMAP_port_change.Location = new System.Drawing.Point(6, 83);
            this.textBox_IMAP_port_change.Name = "textBox_IMAP_port_change";
            this.textBox_IMAP_port_change.Size = new System.Drawing.Size(260, 23);
            this.textBox_IMAP_port_change.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Порт сервера";
            // 
            // textBox_IMAP_adress_change
            // 
            this.textBox_IMAP_adress_change.Location = new System.Drawing.Point(6, 39);
            this.textBox_IMAP_adress_change.Name = "textBox_IMAP_adress_change";
            this.textBox_IMAP_adress_change.Size = new System.Drawing.Size(260, 23);
            this.textBox_IMAP_adress_change.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Адрес сервера";
            // 
            // button_switch_account
            // 
            this.button_switch_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_switch_account.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_switch_account.Location = new System.Drawing.Point(6, 414);
            this.button_switch_account.Name = "button_switch_account";
            this.button_switch_account.Size = new System.Drawing.Size(229, 56);
            this.button_switch_account.TabIndex = 22;
            this.button_switch_account.Text = "Войти в выбранный";
            this.button_switch_account.UseVisualStyleBackColor = false;
            this.button_switch_account.Click += new System.EventHandler(this.button_switch_account_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 562);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки Maily";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_SMTP.ResumeLayout(false);
            this.groupBox_SMTP.PerformLayout();
            this.groupBox_IMAP.ResumeLayout(false);
            this.groupBox_IMAP.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_accounts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_standart_settings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_mail_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_mail_adress;
        private System.Windows.Forms.GroupBox groupBox_SMTP;
        private System.Windows.Forms.CheckBox checkBox_SMTP_SSL;
        private System.Windows.Forms.TextBox textBox_SMTP_port;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_SMTP_adress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox_IMAP;
        private System.Windows.Forms.CheckBox checkBox_IMAP_SSL;
        private System.Windows.Forms.TextBox textBox_IMAP_port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_IMAP_adress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_log_in_account;
        private System.Windows.Forms.Button button_delete_account;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button_change_accounts;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox checkBox_SMTP_SSL_change;
        private System.Windows.Forms.TextBox textBox_SMTP_port_change;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_SMTP_adress_change;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox checkBox_IMAP_SSL_change;
        private System.Windows.Forms.TextBox textBox_IMAP_port_change;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_IMAP_adress_change;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_switch_account;
    }
}