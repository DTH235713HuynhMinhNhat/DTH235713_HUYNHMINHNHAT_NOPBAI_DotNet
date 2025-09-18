using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUOITH2
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
            private void btnTong_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy giá trị từ TextBox và chuyển sang kiểu số nguyên (int)
                int a = int.Parse(txtSoA.Text);
                int b = int.Parse(txtSoB.Text);

                // 2. Thực hiện phép cộng
                int tong = a + b;

                // 3. Hiển thị kết quả trong một MessageBox
                MessageBox.Show(tong.ToString(), "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                // Xử lý lỗi nếu người dùng nhập ký tự không phải số
                MessageBox.Show("Vui lòng nhập đúng định dạng số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

