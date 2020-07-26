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
    public partial class DangNhap : Form 
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        XuLyDatabase xl = new XuLyDatabase();
        static public string soGio;
        static public int idUser;
        static public int soMay;
        static public string matKhau;
        static public double soTien;
        public int[] arrSoMay;
        static public string HoTen;
        public string baoNhieuMay;
        public RadioButton[] arrViTriMay;
        private void DangNhap_Load(object sender, EventArgs e)
        {
            DataTable table = xl.getQuanLi();
            arrViTriMay = new RadioButton[table.Rows.Count];

            for(int i =0;i<table.Rows.Count;i++)
            {
                RadioButton rd = new RadioButton();
                rd.Text = table.Rows[i][0].ToString();
                fpnlSoMay.Controls.Add(rd);
                arrViTriMay[i] = rd;
            }
           
        }
     

        GiaodienQL ql = new GiaodienQL();
        public bool checkDangNhap(string tk, string mk)
        {
            DataTable table = xl.getTaiKhoanUser();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (tk == table.Rows[i][1].ToString() && mk == table.Rows[i][2].ToString())
                {
                    idUser = Int32.Parse(table.Rows[i][0].ToString());
                    matKhau = table.Rows[i][2].ToString();
                    soGio = table.Rows[i][3].ToString();
                    soTien = Double.Parse(table.Rows[i][4].ToString());
                    return true;
                }
            }
            return false;
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
                try
                {
                    DataTable table = xl.getQuanLi();
                
                if (checkDangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == true)
                    {
                        string[] arrGio = soGio.Split(':');
                        int iGioCon = Int32.Parse(arrGio[0]);
                        int iPhutCon = Int32.Parse(arrGio[1]);
                        string tonggio = iGioCon.ToString() + ":" + iPhutCon.ToString();
                        if (iGioCon == 0 && iPhutCon == 0)
                        {
                            MessageBox.Show("Hết giờ chơi", "Hết giờ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            HoTen = txtTaiKhoan.Text;

                            for (int i = 0; i < table.Rows.Count; i++)
                            {
                               if(arrViTriMay[i].Checked == true)
                                {
                                    soMay = i + 1;                    
                                }
                            }
                            if(soMay==0)
                             {
                            MessageBox.Show("Chọn số mấy", "Chọn số máy", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                        }
                        else
                        {
                            GiaoDienUser userr = new GiaoDienUser();
                            xl.dangNhapNgDvaoQuanL(soMay, "Đang dùng", txtTaiKhoan.Text, soGio, soTien, "Chưa gọi");
                            xl.dangNhapVao(idUser, HoTen, tonggio, soTien);
                            userr.Show();
                            txtMatKhau.Clear();
                            txtTaiKhoan.Clear();
                            this.Close();  
                        }
                      
                    }             
                          
                    }
                    else
                    {
                        txtMatKhau.Clear();
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
              
                MessageBox.Show("Tài khoản đăng nhập ở nơi khác" , "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }  
        }

        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Bạn có muốn thoát không? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms == DialogResult.Yes)
            {
                
                this.Close();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
