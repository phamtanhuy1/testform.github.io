using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFrom
{
    public partial class Form1 : Form
    {
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }
        public bool KiemTraNhapLieu()
        {
            bool res = false;
            if (string.IsNullOrEmpty(txtNhapA.Text) || string.IsNullOrEmpty(txtNhapB.Text))
            {
                res = false;
                MessageBox.Show("Chưa nhập A Hoặc B", "Thông Báo");
            }
            else if (!int.TryParse(txtNhapA.Text, out a) || !int.TryParse(txtNhapB.Text, out b))
            {
                res = false;
                MessageBox.Show("sai kiểu dũ liệu", "thông báo");
            }
            else
            
                res = true;
                return res;
            
          
        }


        private void btnTong_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu())
            {
                txtKetqua.Text = (a + b).ToString();
            } 
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu())
            {
                txtKetqua.Text = (a * b).ToString();
            }
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu())
            {
                txtKetqua.Text = ((float)a / b).ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Em có muốn thoát không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu())
            {
                txtKetqua.Text = (a - b).ToString();
            }
        }
    }
}
