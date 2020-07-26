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
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
            TimerChat.Start();
        }
        XuLyDatabase xl = new XuLyDatabase();
        private void btnGui_Click(object sender, EventArgs e)
        {
            //rtbChat.Text+= DangNhap.HoTen.ToString()  +"("+ DateTime.Now.Hour.ToString()+":"+ DateTime.Now.Minute.ToString()+":" + DateTime.Now.Second.ToString() + "): " + txtGui.Text + "\n";
            DateTime dateTime = DateTime.Now;  
            xl.inputChatList(DangNhap.HoTen.ToString(), dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString() + ":" + dateTime.Second.ToString(), txtGui.Text);
            txtGui.Clear();
           
        }

     
        private void Chat_Load(object sender, EventArgs e)
        {

        }

        public void rtbChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbChat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void TimerChat_Tick(object sender, EventArgs e)
        {
            dtgvChat.DataSource = xl.chatList();
            dtgvChat.Columns[0].Width = 50;
            dtgvChat.Columns[1].Width = 50;
            dtgvChat.Columns[2].Width = 180;

        }
    }
}
