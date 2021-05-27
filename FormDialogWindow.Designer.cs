
namespace Maily
{
    partial class FormDialogWindow
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
            this.button_close = new System.Windows.Forms.Button();
            this.text_box_error = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_close.Location = new System.Drawing.Point(12, 145);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(340, 41);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Закрыть";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // text_box_error
            // 
            this.text_box_error.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_box_error.ForeColor = System.Drawing.Color.Red;
            this.text_box_error.Location = new System.Drawing.Point(12, 12);
            this.text_box_error.Name = "text_box_error";
            this.text_box_error.Size = new System.Drawing.Size(340, 127);
            this.text_box_error.TabIndex = 2;
            this.text_box_error.Text = "temp_text";
            // 
            // FormDialogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 198);
            this.Controls.Add(this.text_box_error);
            this.Controls.Add(this.button_close);
            this.Name = "FormDialogWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "temp_text";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.RichTextBox text_box_error;
    }
}