namespace Project
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.btnGui = new System.Windows.Forms.Button();
            this.txtGui = new System.Windows.Forms.TextBox();
            this.TimerChat = new System.Windows.Forms.Timer(this.components);
            this.dtgvChat = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGui
            // 
            this.btnGui.BackColor = System.Drawing.Color.Lavender;
            this.btnGui.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGui.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Location = new System.Drawing.Point(629, 413);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(75, 50);
            this.btnGui.TabIndex = 0;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = false;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // txtGui
            // 
            this.txtGui.Location = new System.Drawing.Point(498, 368);
            this.txtGui.Name = "txtGui";
            this.txtGui.Size = new System.Drawing.Size(206, 22);
            this.txtGui.TabIndex = 1;
            // 
            // TimerChat
            // 
            this.TimerChat.Tick += new System.EventHandler(this.TimerChat_Tick);
            // 
            // dtgvChat
            // 
            this.dtgvChat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChat.Location = new System.Drawing.Point(12, 12);
            this.dtgvChat.Name = "dtgvChat";
            this.dtgvChat.RowTemplate.Height = 24;
            this.dtgvChat.ShowCellToolTips = false;
            this.dtgvChat.Size = new System.Drawing.Size(480, 491);
            this.dtgvChat.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 125);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgvChat);
            this.Controls.Add(this.txtGui);
            this.Controls.Add(this.btnGui);
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.TextBox txtGui;
        private System.Windows.Forms.Timer TimerChat;
        private System.Windows.Forms.DataGridView dtgvChat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}