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
    public partial class ChatAdmin : Form
    {
        public ChatAdmin()
        {
            InitializeComponent();
            tmChat.Start();
        }

        XuLyDatabase xl = new XuLyDatabase();
        private void btnGui_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            xl.inputChatList("Admin", dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString() + ":" + dateTime.Second.ToString(), txtGui.Text);
            txtGui.Clear();
        }

        private void tmChat_Tick(object sender, EventArgs e)
        {
            dtgvChat.DataSource = xl.chatList();
            dtgvChat.Columns[0].Width = 50;
            dtgvChat.Columns[1].Width = 60;
            dtgvChat.Columns[2].Width = 180;
        }

        private void ChatAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
