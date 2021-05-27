using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Maily
{
    public partial class FormDialogWindow : Form
    {
        public FormDialogWindow(String form_name, String error)
        {
            InitializeComponent();
            this.Text = form_name;
            text_box_error.Text = error;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
