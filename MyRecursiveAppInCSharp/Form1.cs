using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRecursiveAppInCSharp
{
    public partial class Form1 : Form
    {

        private int facto(int f)
        {
            if(f == 1)
            {
                return 1;
            }
            else if (f < 1)
            {
                return -1;
            }
            else
            {
                return f * facto(f-1);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtInput.Text, out int f) == false)
            {
                MessageBox.Show("Indiquez un chiffre svp");
            }
            label1.Text = facto(f) + "";
        }
    }
}
