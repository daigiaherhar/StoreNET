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
    public partial class DoAnAdmin : Form
    {
        public DoAnAdmin()
        {
            InitializeComponent();
            
        }
        XuLyDatabase xl = new XuLyDatabase();
        private void DoAnAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                //do an

                



                dtgrDoAn.DataSource = xl.listMonAnKhach();

                dtgrDoAn.Columns[0].Width = 30;
                dtgrDoAn.Columns[1].Width = 200;
                dtgrDoAn.Columns[2].Width = 100;
                lblTinhTien.Text = "Tổng tiền: " + DoAn.tongSoTien.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có gọi đồ ăn" + ex); 
            }
      
          
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Xác nhận thanh toán", "Tính tiền", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            if(r == DialogResult.OK)
            {
                this.Close();
                xl.dangNhapNgDvaoQuanL(DangNhap.soMay, "Đang dùng", DangNhap.HoTen.ToString(), DangNhap.soGio, DangNhap.soTien, "Chưa gọi");
                    DoAn.tongSoTien = 0;
                    xl.deleteListMonAnKhach();                }
            }
            catch
            {
                MessageBox.Show("Không có gọi đồ ăn");
            }
        }
    }
}
