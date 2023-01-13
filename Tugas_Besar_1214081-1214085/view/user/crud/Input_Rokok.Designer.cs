namespace Tugas_Besar_1214081_1214085.view
{
    partial class formInputRokok
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.tbIDMerek = new System.Windows.Forms.TextBox();
            this.dtbTanggal = new System.Windows.Forms.DateTimePicker();
            this.lbTanggal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.cbMerek = new System.Windows.Forms.ComboBox();
            this.lbMerek = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.btSimpan = new System.Windows.Forms.PictureBox();
            this.tbJumlahRokok = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.lbJumlahRokok = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.btMinimize = new System.Windows.Forms.PictureBox();
            this.btClose = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSimpan)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Controls.Add(this.lbNote);
            this.groupBox1.Controls.Add(this.tbNote);
            this.groupBox1.Controls.Add(this.tbIDMerek);
            this.groupBox1.Controls.Add(this.dtbTanggal);
            this.groupBox1.Controls.Add(this.lbTanggal);
            this.groupBox1.Controls.Add(this.tbTotal);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.cbMerek);
            this.groupBox1.Controls.Add(this.lbMerek);
            this.groupBox1.Controls.Add(this.tbHarga);
            this.groupBox1.Controls.Add(this.btSimpan);
            this.groupBox1.Controls.Add(this.tbJumlahRokok);
            this.groupBox1.Controls.Add(this.tbNama);
            this.groupBox1.Controls.Add(this.lbJumlahRokok);
            this.groupBox1.Controls.Add(this.lbNama);
            this.groupBox1.Controls.Add(this.lbLogin);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 441);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.ForeColor = System.Drawing.Color.White;
            this.lbNote.Location = new System.Drawing.Point(6, 260);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(40, 28);
            this.lbNote.TabIndex = 24;
            this.lbNote.Text = "Note";
            // 
            // tbNote
            // 
            this.tbNote.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNote.Location = new System.Drawing.Point(159, 257);
            this.tbNote.MaxLength = 300;
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(233, 104);
            this.tbNote.TabIndex = 23;
            this.tbNote.TextChanged += new System.EventHandler(this.tbNote_TextChanged);
            // 
            // tbIDMerek
            // 
            this.tbIDMerek.Location = new System.Drawing.Point(11, 42);
            this.tbIDMerek.Name = "tbIDMerek";
            this.tbIDMerek.Size = new System.Drawing.Size(100, 20);
            this.tbIDMerek.TabIndex = 22;
            this.tbIDMerek.Visible = false;
            // 
            // dtbTanggal
            // 
            this.dtbTanggal.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbTanggal.Location = new System.Drawing.Point(159, 219);
            this.dtbTanggal.Name = "dtbTanggal";
            this.dtbTanggal.Size = new System.Drawing.Size(233, 30);
            this.dtbTanggal.TabIndex = 21;
            this.dtbTanggal.Value = new System.DateTime(2023, 1, 8, 0, 0, 0, 0);
            // 
            // lbTanggal
            // 
            this.lbTanggal.AutoSize = true;
            this.lbTanggal.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTanggal.ForeColor = System.Drawing.Color.White;
            this.lbTanggal.Location = new System.Drawing.Point(6, 223);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.Size = new System.Drawing.Size(59, 28);
            this.lbTanggal.TabIndex = 20;
            this.lbTanggal.Text = "Tanggal";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(159, 181);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(233, 30);
            this.tbTotal.TabIndex = 19;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(6, 184);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(42, 28);
            this.lbTotal.TabIndex = 18;
            this.lbTotal.Text = "Total";
            // 
            // cbMerek
            // 
            this.cbMerek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMerek.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMerek.FormattingEnabled = true;
            this.cbMerek.Items.AddRange(new object[] {
            "Surya",
            "Sampoerna",
            "Signature",
            "LA",
            "Camel"});
            this.cbMerek.Location = new System.Drawing.Point(159, 100);
            this.cbMerek.Name = "cbMerek";
            this.cbMerek.Size = new System.Drawing.Size(233, 35);
            this.cbMerek.TabIndex = 17;
            this.cbMerek.SelectedIndexChanged += new System.EventHandler(this.cbMerek_SelectedIndexChanged);
            // 
            // lbMerek
            // 
            this.lbMerek.AutoSize = true;
            this.lbMerek.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMerek.ForeColor = System.Drawing.Color.White;
            this.lbMerek.Location = new System.Drawing.Point(6, 103);
            this.lbMerek.Name = "lbMerek";
            this.lbMerek.Size = new System.Drawing.Size(49, 28);
            this.lbMerek.TabIndex = 15;
            this.lbMerek.Text = "Merek";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(11, 16);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(100, 20);
            this.tbHarga.TabIndex = 14;
            this.tbHarga.Visible = false;
            // 
            // btSimpan
            // 
            this.btSimpan.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Simpan;
            this.btSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSimpan.Location = new System.Drawing.Point(11, 391);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(124, 44);
            this.btSimpan.TabIndex = 12;
            this.btSimpan.TabStop = false;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            this.btSimpan.MouseEnter += new System.EventHandler(this.btSimpan_MouseEnter);
            this.btSimpan.MouseLeave += new System.EventHandler(this.btSimpan_MouseLeave);
            // 
            // tbJumlahRokok
            // 
            this.tbJumlahRokok.Enabled = false;
            this.tbJumlahRokok.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJumlahRokok.Location = new System.Drawing.Point(159, 143);
            this.tbJumlahRokok.Name = "tbJumlahRokok";
            this.tbJumlahRokok.Size = new System.Drawing.Size(233, 30);
            this.tbJumlahRokok.TabIndex = 11;
            this.tbJumlahRokok.TextChanged += new System.EventHandler(this.tbJumlahRokok_TextChanged);
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(159, 62);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(233, 30);
            this.tbNama.TabIndex = 10;
            // 
            // lbJumlahRokok
            // 
            this.lbJumlahRokok.AutoSize = true;
            this.lbJumlahRokok.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJumlahRokok.ForeColor = System.Drawing.Color.White;
            this.lbJumlahRokok.Location = new System.Drawing.Point(6, 146);
            this.lbJumlahRokok.Name = "lbJumlahRokok";
            this.lbJumlahRokok.Size = new System.Drawing.Size(120, 28);
            this.lbJumlahRokok.TabIndex = 9;
            this.lbJumlahRokok.Text = "Jumlah (Bungkus)";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNama.ForeColor = System.Drawing.Color.White;
            this.lbNama.Location = new System.Drawing.Point(6, 65);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(47, 28);
            this.lbNama.TabIndex = 8;
            this.lbNama.Text = "Nama";
            // 
            // lbLogin
            // 
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Uighur", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(107, 16);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(192, 43);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "I N P U T";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Turquoise;
            this.Header.Controls.Add(this.btMinimize);
            this.Header.Controls.Add(this.btClose);
            this.Header.Controls.Add(this.pictureBox3);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(429, 52);
            this.Header.TabIndex = 14;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // btMinimize
            // 
            this.btMinimize.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Minimize__2_;
            this.btMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMinimize.Location = new System.Drawing.Point(310, 3);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(46, 46);
            this.btMinimize.TabIndex = 32;
            this.btMinimize.TabStop = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            this.btMinimize.MouseEnter += new System.EventHandler(this.btMinimize_MouseEnter);
            this.btMinimize.MouseLeave += new System.EventHandler(this.btMinimize_MouseLeave);
            // 
            // btClose
            // 
            this.btClose.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Close;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClose.Location = new System.Drawing.Point(380, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(46, 46);
            this.btClose.TabIndex = 31;
            this.btClose.TabStop = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            this.btClose.MouseEnter += new System.EventHandler(this.btClose_MouseEnter);
            this.btClose.MouseLeave += new System.EventHandler(this.btClose_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Icon_Tanpa_Judul;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 46);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // formInputRokok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 514);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "formInputRokok";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formInputRokok_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSimpan)).EndInit();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.PictureBox btSimpan;
        private System.Windows.Forms.TextBox tbJumlahRokok;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label lbJumlahRokok;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbMerek;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ComboBox cbMerek;
        private System.Windows.Forms.DateTimePicker dtbTanggal;
        private System.Windows.Forms.Label lbTanggal;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btMinimize;
        private System.Windows.Forms.PictureBox btClose;
        private System.Windows.Forms.TextBox tbIDMerek;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.TextBox tbNote;
    }
}