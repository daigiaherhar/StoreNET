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
    public partial class GiaodienQL : Form
    {
        public GiaodienQL()
        {
            InitializeComponent();
        }
        XuLyDatabase xl = new XuLyDatabase();
        private void GiaodienQL_Load(object sender, EventArgs e)
        {   
            DangNhap dn = new DangNhap();
            dn.Show();
            timer1.Start();

        }

        private void lsvThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ThongTinNguoiDung tk = new ThongTinNguoiDung();
            tk.Show();
        }

        private void dtgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dtgvThongTin.CurrentCell.RowIndex; // dong
           
            txtSoMay.Text = dtgvThongTin[0, row].Value.ToString();
        }

        private void dtgvThongTin_Click(object sender, EventArgs e)
        {
           // int row = dtgvThongTin.CurrentCell.RowIndex; // dong
           // MessageBox.Show("dòng"+row);
           //dtgvThongTin[0, row].Value.ToString();
           //  dtgvThongTin[1, row].Value.ToString();

        }

        private void tínhTiềnĐồĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                DoAnAdmin doa = new DoAnAdmin();
                doa.Show();
            

        }

        //private void thêmGiờToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    addGio addgio = new addGio();
        //    addgio.Show();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            adThemDoAn doan = new adThemDoAn();
            doan.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataTime = DateTime.Now;
            lblThoiGian.Text = dataTime.ToString();
            dtgvThongTin.DataSource = xl.getQuanLi();
        }

        private void btnTat_Click(object sender, EventArgs e)
        {
            try
            {
                xl.themMay(Int32.Parse(txtSoMay.Text), "Không hoạt động", "", "0:0", 0, "Chưa gọi");
            }
            catch
            {
                MessageBox.Show("Số máy đó đã có");
            }
           

        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChatAdmin chatAD = new ChatAdmin();
            chatAD.Show();
        }

        static public int tatMay = 0;
        private void tắtMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tatMay++;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                xl.deleteMay(Int32.Parse(txtSoMay.Text));
            }
            catch
            {
                MessageBox.Show("Số máy đó đã có");
            }
        }
    }
}
