namespace Project
{
    partial class DoAnAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoAnAdmin));
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lblTinhTien = new System.Windows.Forms.Label();
            this.dtgrDoAn = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDoAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.Color.Gold;
            this.btnTinhTien.Location = new System.Drawing.Point(452, 375);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(125, 65);
            this.btnTinhTien.TabIndex = 0;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lblTinhTien
            // 
            this.lblTinhTien.AutoSize = true;
            this.lblTinhTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTien.Location = new System.Drawing.Point(244, 395);
            this.lblTinhTien.Name = "lblTinhTien";
            this.lblTinhTien.Size = new System.Drawing.Size(112, 23);
            this.lblTinhTien.TabIndex = 6;
            this.lblTinhTien.Text = "Tổng tiền: 0";
            // 
            // dtgrDoAn
            // 
            this.dtgrDoAn.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgrDoAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrDoAn.Location = new System.Drawing.Point(12, 128);
            this.dtgrDoAn.Name = "dtgrDoAn";
            this.dtgrDoAn.RowTemplate.Height = 24;
            this.dtgrDoAn.Size = new System.Drawing.Size(631, 241);
            this.dtgrDoAn.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 125);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // DoAnAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgrDoAn);
            this.Controls.Add(this.lblTinhTien);
            this.Controls.Add(this.btnTinhTien);
            this.Name = "DoAnAdmin";
            this.Text = "DoAnAdmin";
            this.Load += new System.EventHandler(this.DoAnAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDoAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lblTinhTien;
        private System.Windows.Forms.DataGridView dtgrDoAn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}