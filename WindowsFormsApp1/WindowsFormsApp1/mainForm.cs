using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
        }

        private void pressButton_Click(object sender, EventArgs e)
        {

            if (textBox.Text != "" && signTextBox.Text != "")
            {
                resultForm Form1 = new resultForm(textBox.Text, signTextBox.Text);
                Form1.Show();
            }
            else
                MessageBox.Show("Некторые поля не заполнены", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
        }
    }
}
