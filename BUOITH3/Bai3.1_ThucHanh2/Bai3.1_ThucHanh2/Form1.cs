using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._1_ThucHanh2
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            if (!double.TryParse(txtX.Text.Trim(), out x))
            {
                MessageBox.Show("Vui lòng nhập một số thực hợp lệ cho x.", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtX.Focus();
                return;
            }

            double f;
            if (x >= 2.0)
            {
                f = -8.0 * Math.Pow(x, 3) - 12.0 * x - 1.0;
            }
            else if (x > 1.0 && x < 2.0) // 1 < x < 2
            {
                f = x * x - 6.0 * x - 19.0;
            }
            else // x <= 1
            {
                f = 7.0 * x;
            }

            // Hiển thị (định dạng nếu cần)
            txtF.Text = f.ToString();
        }
    }
}
