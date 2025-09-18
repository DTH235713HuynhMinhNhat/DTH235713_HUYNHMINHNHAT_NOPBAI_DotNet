using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._4_ThucHanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (!double.TryParse(txtA.Text.Trim(), out a) ||
                !double.TryParse(txtB.Text.Trim(), out b) ||
                !double.TryParse(txtC.Text.Trim(), out c))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho a, b, c.");
                return;
            }

            string ketQua = "";

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0) ketQua = "PT vô số nghiệm.";
                    else ketQua = "PT vô nghiệm.";
                }
                else
                {
                    double x = -c / b;
                    ketQua = "PT bậc nhất có nghiệm: x = " + x;
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    ketQua = "PT vô nghiệm.";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    ketQua = "PT có nghiệm kép: x = " + x;
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    ketQua = "PT có 2 nghiệm: x1 = " + x1 + ", x2 = " + x2;
                }
            }

            txtKetQua.Text = ketQua;
        }
    }
}
