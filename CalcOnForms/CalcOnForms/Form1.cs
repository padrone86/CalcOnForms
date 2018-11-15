using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcOnForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int num1, num2;

            if (!int.TryParse(textBox1.Text, out num1))
            {
                num1 = 0;
            }
            if (!int.TryParse(textBox2.Text, out num2))
            {
                num2 = 0;
            }

            textBox3.Text = (num1 + num2).ToString();
        }
    }
}
