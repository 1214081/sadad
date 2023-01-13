namespace Tugas_Besar_1214081_1214085.view
{
    partial class formDashboardAdmin
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
            this.Header = new System.Windows.Forms.Panel();
            this.btMinimize = new System.Windows.Forms.PictureBox();
            this.btClose = new System.Windows.Forms.PictureBox();
            this.btPesan = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btMerek = new System.Windows.Forms.PictureBox();
            this.btLogout = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPesan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMerek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Turquoise;
            this.Header.Controls.Add(this.btLogout);
            this.Header.Controls.Add(this.btMinimize);
            this.Header.Controls.Add(this.btClose);
            this.Header.Controls.Add(this.btPesan);
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.btMerek);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1364, 52);
            this.Header.TabIndex = 11;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // btMinimize
            // 
            this.btMinimize.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Minimize__2_;
            this.btMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMinimize.Location = new System.Drawing.Point(1245, 3);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(46, 46);
            this.btMinimize.TabIndex = 30;
            this.btMinimize.TabStop = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            this.btMinimize.MouseEnter += new System.EventHandler(this.btMinimize_MouseEnter);
            this.btMinimize.MouseLeave += new System.EventHandler(this.btMinimize_MouseLeave);
            // 
            // btClose
            // 
            this.btClose.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Close;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClose.Location = new System.Drawing.Point(1315, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(46, 46);
            this.btClose.TabIndex = 20;
            this.btClose.TabStop = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            this.btClose.MouseEnter += new System.EventHandler(this.btClose_MouseEnter);
            this.btClose.MouseLeave += new System.EventHandler(this.btClose_MouseLeave);
            // 
            // btPesan
            // 
            this.btPesan.BackColor = System.Drawing.Color.Turquoise;
            this.btPesan.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Pesan;
            this.btPesan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesan.Location = new System.Drawing.Point(344, 4);
            this.btPesan.Name = "btPesan";
            this.btPesan.Size = new System.Drawing.Size(124, 44);
            this.btPesan.TabIndex = 21;
            this.btPesan.TabStop = false;
            this.btPesan.Click += new System.EventHandler(this.btPesan_Click);
            this.btPesan.MouseEnter += new System.EventHandler(this.btPesan_MouseEnter);
            this.btPesan.MouseLeave += new System.EventHandler(this.btPesan_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Icon_Tanpa_Judul;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btMerek
            // 
            this.btMerek.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Merek;
            this.btMerek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMerek.Location = new System.Drawing.Point(119, 4);
            this.btMerek.Name = "btMerek";
            this.btMerek.Size = new System.Drawing.Size(124, 44);
            this.btMerek.TabIndex = 19;
            this.btMerek.TabStop = false;
            this.btMerek.Click += new System.EventHandler(this.btMerek_Click);
            this.btMerek.MouseEnter += new System.EventHandler(this.btMerek_MouseEnter);
            this.btMerek.MouseLeave += new System.EventHandler(this.btMerek_MouseLeave);
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.Turquoise;
            this.btLogout.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Logout;
            this.btLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLogout.Location = new System.Drawing.Point(569, 4);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(124, 44);
            this.btLogout.TabIndex = 31;
            this.btLogout.TabStop = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            this.btLogout.MouseEnter += new System.EventHandler(this.btLogout_MouseEnter);
            this.btLogout.MouseLeave += new System.EventHandler(this.btLogout_MouseLeave);
            // 
            // formDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 766);
            this.Controls.Add(this.Header);
            this.IsMdiContainer = true;
            this.Name = "formDashboardAdmin";
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPesan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMerek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox btMinimize;
        private System.Windows.Forms.PictureBox btClose;
        private System.Windows.Forms.PictureBox btPesan;
        private System.Windows.Forms.PictureBox btMerek;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btLogout;
    }
}