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
    public partial class adThemDoAn : Form
    {
        public adThemDoAn()
        {
            InitializeComponent();
        }
        XuLyDatabase xl = new XuLyDatabase();
        private void button1_Click(object sender, EventArgs e)
        {
          
                DialogResult r = MessageBox.Show("Thoát", "Out", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                if (r == DialogResult.OK)
                {
                    this.Close();

                }
        }

        private void adThemDoAn_Load(object sender, EventArgs e)
        {
            dtgvDoAn.DataSource = xl.getDoAn();
            dtgvDoUong.DataSource = xl.getDoUong();
        }

        private void btnDoAn_Click(object sender, EventArgs e)
        {  
                xl.themDoAn(txtDoAn.Text, Int32.Parse(txtGiaDoAn.Text));
            dtgvDoAn.DataSource = xl.getDoAn();
        }

        private void btnDoUong_Click(object sender, EventArgs e)
        {
            xl.themDoUong(txtDoUong.Text, Int32.Parse(txtGiaDoUong.Text));
            dtgvDoUong.DataSource = xl.getDoUong();
        }

        private void dtgvDoAn_Click(object sender, EventArgs e)
        {
            int row = dtgvDoAn.CurrentCell.RowIndex;
            txtIdDoAn.Text = dtgvDoAn.Rows[row].Cells[0].Value.ToString();
            txtDoAn.Text = dtgvDoAn.Rows[row].Cells[1].Value.ToString();
            txtGiaDoAn.Text = dtgvDoAn.Rows[row].Cells[2].Value.ToString();
        }

        private void btnXoaDoAn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Có thật sự muốn XÓA không?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                if (r == DialogResult.OK)
                {
                    xl.deleteDoAn(Int32.Parse(txtIdDoAn.Text), txtDoAn.Text);
                    dtgvDoAn.DataSource = xl.getDoAn();
                }
            }
            catch
            {
                MessageBox.Show("Chọn id bên dưới");
            }
            
         
           
        }

        private void btnXoaDoUong_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Có thật sự muốn XÓA không?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                if (r == DialogResult.OK)
                {
                    xl.deleteDoUong(Int32.Parse(txtIdDoUong.Text), txtDoUong.Text);
                    dtgvDoUong.DataSource = xl.getDoUong();
                }
            }
            catch
            {
                MessageBox.Show("Chọn id bên dưới");
            }
           
        }

        private void dtgvDoUong_Click(object sender, EventArgs e)
        {
            int row = dtgvDoUong.CurrentCell.RowIndex;
            txtIdDoUong.Text = dtgvDoUong.Rows[row].Cells[0].Value.ToString();
            txtDoUong.Text = dtgvDoUong.Rows[row].Cells[1].Value.ToString();
            txtGiaDoUong.Text = dtgvDoUong.Rows[row].Cells[2].Value.ToString();
        }

        private void btnSuaDoUong_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Có thật sự muốn SỬA không?", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                if (r == DialogResult.OK)
                {
                    xl.updateDoUong(Int32.Parse(txtIdDoUong.Text), txtDoUong.Text, float.Parse(txtGiaDoUong.Text));
                    dtgvDoUong.DataSource = xl.getDoUong();
                }
            }
            catch
            {
                MessageBox.Show("Chọn id bên dưới");
            }
          
        }

        private void btnSuaDoAn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Có thật sự muốn SỬA không?", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                if (r == DialogResult.OK)
                {
                    xl.updateDoAn(Int32.Parse(txtIdDoAn.Text), txtDoAn.Text, float.Parse(txtGiaDoAn.Text));
                    dtgvDoAn.DataSource = xl.getDoAn();
                }
            }
            catch
            {
                MessageBox.Show("Chọn id bên dưới");
            }
          
        }
    }
}
