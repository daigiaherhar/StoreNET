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
    public partial class DoAn : Form
    {
        static public double[] soTien;
        static public double[] soTien1;
        static public double tongSoTien;
        int[] iId;
        static public CheckBox[] cbb;
        static public string[] tenDoAn;
        static public NumericUpDown[] num;
        static public string[] tenDoUong;
        static public CheckBox[] cbb1;
        static public NumericUpDown[] num1;
        public DoAn()
        {
            InitializeComponent();

           
        }
        

        XuLyDatabase xl = new XuLyDatabase();
        private void DoAn_Load(object sender, EventArgs e)
        {
            xuLyDoAn();
            xuLyDoUong();

        }
        private void xuLyDoUong()
        {
            DataTable tableDoUong = xl.getDoUong();
            cbb1 = new CheckBox[tableDoUong.Rows.Count];
            soTien1 = new double[tableDoUong.Rows.Count];
            num1 = new NumericUpDown[tableDoUong.Rows.Count];
            tenDoUong = new string[tableDoUong.Rows.Count];
            for (int i = 0; i < tableDoUong.Rows.Count; i++)
            {
                iId[i] = Int32.Parse(tableDoUong.Rows[i][0].ToString());

                CheckBox cb = new CheckBox()
                {
                    Name = "cbb" + i,
                    Checked = false
                };
                NumericUpDown number = new NumericUpDown()
                {
                    Width = 40,
                    Height = 40
                };
                Label lb = new Label();
                cb.Text = tableDoUong.Rows[i][1].ToString();
                lb.Text = ":" + tableDoUong.Rows[i][2].ToString();
                tenDoUong[i] = tableDoUong.Rows[i][1].ToString();
                soTien1[i] = Double.Parse(tableDoUong.Rows[i][2].ToString());
                fpnlDoUong.Controls.Add(cb);
                fpnlDoUong.Controls.Add(lb);
                fpnlDoUong.Controls.Add(number);
                num1[i] = number;
                cbb1[i] = cb;
                
            }
        }
        private void xuLyDoAn()
        {
            DataTable table = xl.getDoAn();

            iId = new int[40];
            cbb = new CheckBox[table.Rows.Count];
            soTien = new double[table.Rows.Count];
            num = new NumericUpDown[table.Rows.Count];
            tenDoAn = new string[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                iId[i] = Int32.Parse(table.Rows[i][0].ToString());

                CheckBox cb = new CheckBox()
                {
                    Name = "cb" + i,
                    Checked = false
                };
                NumericUpDown number = new NumericUpDown()
                {
                    Width = 40,
                    Height = 40
                };
                Label lb = new Label();
                cb.Text = table.Rows[i][1].ToString();
                lb.Text = ":" + table.Rows[i][2].ToString();
                tenDoAn[i]= table.Rows[i][1].ToString();
                soTien[i] = Double.Parse(table.Rows[i][2].ToString());
                fpnlDoAn.Controls.Add(cb);
                fpnlDoAn.Controls.Add(lb);
                fpnlDoAn.Controls.Add(number);
                num[i] = number;
                cbb[i] = cb;
            }
        }
        private void fpnlDoAn_Click(object sender, EventArgs e)
        {
           
        }
       static public string a;
        static public string[] b ;
        static public string c;
        static public string[] d;

        static public string aa;
        static public string[] bb;
        static public string cc;
        static public string[] dd;

        double doAn = 0;
        double doUong = 0;

        int demDoAn = 0;
        int demDoUong = 0;
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            
            
            DataTable table = xl.getDoAn();
            
            for (int i =0; i< table.Rows.Count; i++)
            {
                if (cbb[i].Checked == true)
                {
                    demDoAn++;
                    a += tenDoAn[i] +" - ";
                    c += Decimal.ToDouble(num[i].Value) + " - ";
                    doAn += Decimal.ToDouble(num[i].Value) * soTien[i];
                }
            }

            DataTable tableDoUong = xl.getDoUong();
            for (int i = 0; i < tableDoUong.Rows.Count; i++)
            {

                if (cbb1[i].Checked == true)
                {
                    demDoUong++;
                    aa += tenDoUong[i] + " - ";
                    cc += Decimal.ToDouble(num1[i].Value) + " - ";
                    doUong += Decimal.ToDouble(num1[i].Value) * soTien1[i];
                   
                }

            }
            tongSoTien += doAn + doUong;
            lblSoTien.Text = "Số tiền: " + tongSoTien.ToString() +" VNĐ";

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            tongSoTien = 0;
            lblSoTien.Text = "Số tiền: 0 VNĐ";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblSoTien.Text == "Số tiền: 0 VNĐ")
                {
                    MessageBox.Show("Vui lòng chọn món", "Thua", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    DialogResult r = MessageBox.Show("Xác nhận thanh toán", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (r == DialogResult.Yes)
                    {
                        xl.userGoiMon(DangNhap.soMay, "Đang gọi món");
                        //b = a.Split('-');
                        //bb = aa.Split('-');
                        //d = c.Split('-');
                        //dd = cc.Split('-');
                     
                          
                        if(demDoAn>0)
                        {
                            xl.inputMonAnKhach(a, c, doAn);
                            demDoAn = 0;
                        }

                        if(demDoUong >0)
                        {
                            xl.inputMonAnKhach(aa, cc, doUong);
                            demDoUong = 0;
                        }
                        
                       
                        a = "";
                        c = "";
                        cc = "";
                        aa = "";
                        this.Close();
                        
                    }

                }
            }catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
          
          

       
        }
    }
}
