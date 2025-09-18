using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._1_ThucHanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            double S = 0;

            // Bài 4.1: S = 1 + 2 + ... + n
             for (int i = 1; i <= n; i++)
            {
                S += i;
            }
            txtS.Text = S.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
