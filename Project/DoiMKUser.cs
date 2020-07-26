using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class DoiMKUser : Form
    {
        public DoiMKUser()
        {
            InitializeComponent();
        }
        XuLyDatabase xl = new XuLyDatabase();
        private void DoiMKUser_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Enabled = false;
            txtTaiKhoan.Text = DangNhap.HoTen;
          
        }
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
           if(txtMKHienTai.Text == DangNhap.matKhau )
            {
                
                if (txtMatKhau.Text == txtNhapLai.Text)
                {
                    xl.doiMKUser(DangNhap.idUser, txtMatKhau.Text);
                    MessageBox.Show("Đổi mật khẩu thành công!", "Win", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                }
                else
                {
                    errorProvider1.SetError(txtMatKhau, "Không đúng");
                }

               
            }
           else
            {
                errorProvider1.SetError(txtMKHienTai, "Không đúng");
            }
           
            
            if(txtMatKhau.Text == string.Empty )
            {
                errorProvider1.SetError(txtMatKhau, "Không để trống!");
            }
            if(txtNhapLai.Text == string.Empty)
            {
                errorProvider1.SetError(txtNhapLai, "Không để trống!");
            }
         

            
        }
    }
}
