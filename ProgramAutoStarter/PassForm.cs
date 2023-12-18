using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ConfigDefender
{
    public partial class PassForm : Form
    {
        private string pw="";
        public PassForm(string correctPW)
        {
            InitializeComponent();
            pw = correctPW;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pw == textBox1.Text)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Incorrect password!");
                this.DialogResult = DialogResult.Cancel;
            }           
            this.Close();
        }

        private void PassForm_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
