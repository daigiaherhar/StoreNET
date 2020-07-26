namespace Project
{
    partial class GiaoDienUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThoiGianDung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.btnGiaoTiep = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoGio = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSoMay = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDoiMk = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblThoiGianDung);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblThoiGian);
            this.panel1.Controls.Add(this.btnGiaoTiep);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSoGio);
            this.panel1.Controls.Add(this.lblSoTien);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblSoMay);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnDoiMk);
            this.panel1.Location = new System.Drawing.Point(420, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 491);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblThoiGianDung
            // 
            this.lblThoiGianDung.AutoSize = true;
            this.lblThoiGianDung.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianDung.Location = new System.Drawing.Point(151, 84);
            this.lblThoiGianDung.Name = "lblThoiGianDung";
            this.lblThoiGianDung.Size = new System.Drawing.Size(95, 16);
            this.lblThoiGianDung.TabIndex = 7;
            this.lblThoiGianDung.Text = "Thời gian dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thơi gian đã dùng:";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(73, 455);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(89, 23);
            this.lblThoiGian.TabIndex = 5;
            this.lblThoiGian.Text = "Thời gian";
            // 
            // btnGiaoTiep
            // 
            this.btnGiaoTiep.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGiaoTiep.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoTiep.Location = new System.Drawing.Point(15, 173);
            this.btnGiaoTiep.Name = "btnGiaoTiep";
            this.btnGiaoTiep.Size = new System.Drawing.Size(272, 27);
            this.btnGiaoTiep.TabIndex = 4;
            this.btnGiaoTiep.Text = "Giao tiếp";
            this.btnGiaoTiep.UseVisualStyleBackColor = true;
            this.btnGiaoTiep.Click += new System.EventHandler(this.btnGiaoTiep_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số giờ có:";
            // 
            // lblSoGio
            // 
            this.lblSoGio.AutoSize = true;
            this.lblSoGio.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoGio.Location = new System.Drawing.Point(77, 50);
            this.lblSoGio.Name = "lblSoGio";
            this.lblSoGio.Size = new System.Drawing.Size(44, 16);
            this.lblSoGio.TabIndex = 3;
            this.lblSoGio.Text = "Số giờ";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.Location = new System.Drawing.Point(173, 50);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(47, 16);
            this.lblSoTien.TabIndex = 3;
            this.lblSoTien.Text = "Số tiền";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(151, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 19);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblSoMay
            // 
            this.lblSoMay.AutoSize = true;
            this.lblSoMay.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoMay.Location = new System.Drawing.Point(20, 0);
            this.lblSoMay.Name = "lblSoMay";
            this.lblSoMay.Size = new System.Drawing.Size(62, 19);
            this.lblSoMay.TabIndex = 3;
            this.lblSoMay.Text = "Máy-";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(113, 219);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 30);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(15, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(272, 34);
            this.button5.TabIndex = 2;
            this.button5.Text = "Gọi món";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDoiMk
            // 
            this.btnDoiMk.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMk.Location = new System.Drawing.Point(154, 123);
            this.btnDoiMk.Name = "btnDoiMk";
            this.btnDoiMk.Size = new System.Drawing.Size(133, 35);
            this.btnDoiMk.TabIndex = 1;
            this.btnDoiMk.Text = "Đổi mật khẩu";
            this.btnDoiMk.UseVisualStyleBackColor = true;
            this.btnDoiMk.Click += new System.EventHandler(this.btnDoiMk_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 227);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GiaoDienUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "GiaoDienUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaoDienUser";
            this.Load += new System.EventHandler(this.GiaoDienUser_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDoiMk;
        private System.Windows.Forms.Label lblSoMay;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblSoGio;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnGiaoTiep;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblThoiGianDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}