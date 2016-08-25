using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = fibonacci(9).ToString();
        }

         int fibonacci(int num)
        {
           
            if(num == 1)
            {
                return 0;
            }
            if (num == 2)
            {
                return 1;
            }
           
            return fibonacci(num - 1) + fibonacci(num - 2);
        }
    }
}
