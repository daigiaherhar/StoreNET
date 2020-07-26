namespace Project
{
    partial class GiaodienQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaodienQL));
            this.dtgvThongTin = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tínhTiềnĐồĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tắtMáyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.txtSoMay = new System.Windows.Forms.TextBox();
            this.btnTat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTin)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvThongTin
            // 
            this.dtgvThongTin.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dtgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongTin.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgvThongTin.Location = new System.Drawing.Point(9, 192);
            this.dtgvThongTin.Name = "dtgvThongTin";
            this.dtgvThongTin.ReadOnly = true;
            this.dtgvThongTin.RowTemplate.Height = 24;
            this.dtgvThongTin.Size = new System.Drawing.Size(827, 269);
            this.dtgvThongTin.TabIndex = 1;
            this.dtgvThongTin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThongTin_CellContentClick);
            this.dtgvThongTin.Click += new System.EventHandler(this.dtgvThongTin_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tínhTiềnĐồĂnToolStripMenuItem,
            this.chatToolStripMenuItem,
            this.tắtMáyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 76);
            // 
            // tínhTiềnĐồĂnToolStripMenuItem
            // 
            this.tínhTiềnĐồĂnToolStripMenuItem.Name = "tínhTiềnĐồĂnToolStripMenuItem";
            this.tínhTiềnĐồĂnToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.tínhTiềnĐồĂnToolStripMenuItem.Text = "Tính tiền đồ ăn";
            this.tínhTiềnĐồĂnToolStripMenuItem.Click += new System.EventHandler(this.tínhTiềnĐồĂnToolStripMenuItem_Click);
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.chatToolStripMenuItem.Text = "Chat";
            this.chatToolStripMenuItem.Click += new System.EventHandler(this.chatToolStripMenuItem_Click);
            // 
            // tắtMáyToolStripMenuItem
            // 
            this.tắtMáyToolStripMenuItem.Name = "tắtMáyToolStripMenuItem";
            this.tắtMáyToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.tắtMáyToolStripMenuItem.Text = "Tắt máy";
            this.tắtMáyToolStripMenuItem.Click += new System.EventHandler(this.tắtMáyToolStripMenuItem_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.Lavender;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Location = new System.Drawing.Point(12, 12);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(194, 79);
            this.btnTaiKhoan.TabIndex = 2;
            this.btnTaiKhoan.Text = "Thông tin người dùng";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(626, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm đồ ăn trong menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(619, 490);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(96, 22);
            this.lblThoiGian.TabIndex = 5;
            this.lblThoiGian.Text = "Thời gian:";
            // 
            // txtSoMay
            // 
            this.txtSoMay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoMay.Location = new System.Drawing.Point(93, 488);
            this.txtSoMay.Name = "txtSoMay";
            this.txtSoMay.Size = new System.Drawing.Size(54, 30);
            this.txtSoMay.TabIndex = 6;
            // 
            // btnTat
            // 
            this.btnTat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTat.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTat.Location = new System.Drawing.Point(189, 467);
            this.btnTat.Name = "btnTat";
            this.btnTat.Size = new System.Drawing.Size(105, 63);
            this.btnTat.TabIndex = 8;
            this.btnTat.Text = "Thêm máy";
            this.btnTat.UseVisualStyleBackColor = false;
            this.btnTat.Click += new System.EventHandler(this.btnTat_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(336, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 63);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xóa máy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số máy:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 174);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // GiaodienQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTat);
            this.Controls.Add(this.txtSoMay);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTaiKhoan);
            this.Controls.Add(this.dtgvThongTin);
            this.Name = "GiaodienQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Giao diện quản lí";
            this.Load += new System.EventHandler(this.GiaodienQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTin)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvThongTin;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tínhTiềnĐồĂnToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.TextBox txtSoMay;
        private System.Windows.Forms.Button btnTat;
        private System.Windows.Forms.ToolStripMenuItem tắtMáyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

