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
    public partial class  GiaoDienUser : Form
    {
        public GiaoDienUser()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }
        XuLyDatabase xl = new XuLyDatabase();
        private void GiaoDienUser_Load_1(object sender, EventArgs e)
        {
            lblSoMay.Text += " " + DangNhap.soMay;
            lblName.Text = "Xin chào "+ DangNhap.HoTen;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            xl.dangNhapNgDvaoQuanL(DangNhap.soMay, "Không hoạt động", "", "0:0:0", 0,"Chưa gọi");
            xl.xoaDangNhap(DangNhap.idUser);

            DangNhap dn = new DangNhap();
            DangNhap.soMay = 0;
            dn.Show();
            
            this.Close();
            
        }

        private void btnDoiMk_Click(object sender, EventArgs e)
        {
          
            DoiMKUser doimk = new DoiMKUser();
            doimk.Show();
        }

        private void btnGiaoTiep_Click(object sender, EventArgs e)
        {
            xl.clearChatList();
            Chat chat = new Chat();
            chat.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DoAn da = new DoAn();
            da.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(GiaodienQL.tatMay >=1)
            {
                xl.dangNhapNgDvaoQuanL(DangNhap.soMay, "Không hoạt động", "", "0:0:0", 0, "Chưa gọi");
                xl.xoaDangNhap(DangNhap.idUser);

                DangNhap dn = new DangNhap();
                DangNhap.soMay = 0;
                dn.Show();

                this.Close();
                GiaodienQL.tatMay = 0;
            }
            DateTime dataTime = DateTime.Now;
            lblThoiGian.Text = dataTime.ToString();

        }



        int iGiay = 0;
        int iGio = 0;
        int iPhut = 0;

        int dem = 1;
        int iGiayCon = 0;
        int iGioCon = 0;
        int iPhutCon = 0;
        double dSoTien = 0;

        string sTongSoGioCon = "";
        private void timer2_Tick(object sender, EventArgs e)
        {

            iGiay++;
            if(iGiay == 60)
            {
                iPhut++;
                iGiay = 0;
            }else if(iPhut == 60)
            {
                iGio++;
                iPhut = 0;
            }
            lblThoiGianDung.Text = iGio.ToString() + ":" + iPhut.ToString() + ":" + iGiay.ToString();
            

            if(dem ==1)
            {
                string[] arrGio = DangNhap.soGio.Split(':');

                iGiayCon = Int32.Parse(arrGio[2]) +1;
                iGioCon = Int32.Parse(arrGio[0]) ;
                iPhutCon = Int32.Parse(arrGio[1]) +1;

                dSoTien = DangNhap.soTien;
                dem++;
            }

            iGiayCon--;

            if (iGiayCon == 0)
            {   
                if(iPhutCon ==0 && iGioCon ==0 )
                {
                    iGiayCon = 0;
                }
                else
                {
                    iPhutCon--;
                    iGiayCon = 59;
                }     
            }
            if (iPhutCon == 0)
            {
                if (iGioCon == 0)
                {
                    iPhutCon = 0;
                }
                else
                {
                    iGioCon--;
                    iPhutCon = 59;
                }
               

            }
            if (iPhutCon == 0 && iGioCon == 0 && iGiayCon ==0)
            {
                xl.dangNhapNgDvaoQuanL(DangNhap.soMay, "Không hoạt động", "", "0:0:0", 0, "Chưa gọi");
                xl.xoaDangNhap(DangNhap.idUser);

                DangNhap dn = new DangNhap();
                DangNhap.soMay = 0;
                dn.Show();
                this.Close();
            }

            lblSoGio.Text = iGioCon.ToString() + ":" + iPhutCon.ToString() + ":" + iGiayCon.ToString();
            sTongSoGioCon = iGioCon.ToString() + ":" + iPhutCon.ToString() ;
            dSoTien -= 1;
            lblSoTien.Text = "Số tiền còn:" + dSoTien.ToString();

            

          
                xl.capNhatTaiKhoan(DangNhap.idUser, sTongSoGioCon, dSoTien);
                xl.capnhatDangNhapNgDvaoQuanL(DangNhap.soMay, DangNhap.HoTen, sTongSoGioCon, dSoTien);
            
        }

            
    
    }
}
