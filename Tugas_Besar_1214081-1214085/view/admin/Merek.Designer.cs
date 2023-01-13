namespace Tugas_Besar_1214081_1214085.view.admin
{
    partial class formMerek
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
            this.btSimpan = new System.Windows.Forms.PictureBox();
            this.btEdit = new System.Windows.Forms.PictureBox();
            this.DataRokok = new System.Windows.Forms.DataGridView();
            this.Header = new System.Windows.Forms.Panel();
            this.btMinimize = new System.Windows.Forms.PictureBox();
            this.btClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataAlkohol = new System.Windows.Forms.DataGridView();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.lbTabel = new System.Windows.Forms.Label();
            this.cbTabel = new System.Windows.Forms.ComboBox();
            this.lbHarga = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.lbNama = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataRokok)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataAlkohol)).BeginInit();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSimpan
            // 
            this.btSimpan.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Simpan;
            this.btSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSimpan.Location = new System.Drawing.Point(306, 326);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(124, 44);
            this.btSimpan.TabIndex = 13;
            this.btSimpan.TabStop = false;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            this.btSimpan.MouseEnter += new System.EventHandler(this.btSimpan_MouseEnter);
            this.btSimpan.MouseLeave += new System.EventHandler(this.btSimpan_MouseLeave);
            // 
            // btEdit
            // 
            this.btEdit.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Edit;
            this.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEdit.Location = new System.Drawing.Point(306, 384);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(124, 44);
            this.btEdit.TabIndex = 14;
            this.btEdit.TabStop = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            this.btEdit.MouseEnter += new System.EventHandler(this.btEdit_MouseEnter);
            this.btEdit.MouseLeave += new System.EventHandler(this.btEdit_MouseLeave);
            // 
            // DataRokok
            // 
            this.DataRokok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataRokok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataRokok.Location = new System.Drawing.Point(12, 58);
            this.DataRokok.Name = "DataRokok";
            this.DataRokok.Size = new System.Drawing.Size(418, 121);
            this.DataRokok.TabIndex = 16;
            this.DataRokok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataRokok_CellClick);
            this.DataRokok.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataRokok_CellDoubleClick);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Turquoise;
            this.Header.Controls.Add(this.btMinimize);
            this.Header.Controls.Add(this.btClose);
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(442, 52);
            this.Header.TabIndex = 17;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // btMinimize
            // 
            this.btMinimize.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Minimize__2_;
            this.btMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMinimize.Location = new System.Drawing.Point(323, 3);
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
            this.btClose.Location = new System.Drawing.Point(393, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(46, 46);
            this.btClose.TabIndex = 31;
            this.btClose.TabStop = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            this.btClose.MouseEnter += new System.EventHandler(this.btClose_MouseEnter);
            this.btClose.MouseLeave += new System.EventHandler(this.btClose_MouseLeave);
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
            // DataAlkohol
            // 
            this.DataAlkohol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataAlkohol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAlkohol.Location = new System.Drawing.Point(12, 185);
            this.DataAlkohol.Name = "DataAlkohol";
            this.DataAlkohol.Size = new System.Drawing.Size(418, 121);
            this.DataAlkohol.TabIndex = 18;
            this.DataAlkohol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataAlkohol_CellClick);
            this.DataAlkohol.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataAlkohol_CellDoubleClick);
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.Turquoise;
            this.gb1.Controls.Add(this.lbTabel);
            this.gb1.Controls.Add(this.cbTabel);
            this.gb1.Controls.Add(this.lbHarga);
            this.gb1.Controls.Add(this.tbHarga);
            this.gb1.Controls.Add(this.lbNama);
            this.gb1.Controls.Add(this.tbNama);
            this.gb1.Location = new System.Drawing.Point(12, 326);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(256, 160);
            this.gb1.TabIndex = 19;
            this.gb1.TabStop = false;
            // 
            // lbTabel
            // 
            this.lbTabel.AutoSize = true;
            this.lbTabel.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTabel.ForeColor = System.Drawing.Color.White;
            this.lbTabel.Location = new System.Drawing.Point(6, 22);
            this.lbTabel.Name = "lbTabel";
            this.lbTabel.Size = new System.Drawing.Size(44, 28);
            this.lbTabel.TabIndex = 25;
            this.lbTabel.Text = "Tabel";
            // 
            // cbTabel
            // 
            this.cbTabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTabel.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTabel.FormattingEnabled = true;
            this.cbTabel.Items.AddRange(new object[] {
            "Rokok",
            "Alkohol"});
            this.cbTabel.Location = new System.Drawing.Point(90, 19);
            this.cbTabel.Name = "cbTabel";
            this.cbTabel.Size = new System.Drawing.Size(160, 35);
            this.cbTabel.TabIndex = 24;
            // 
            // lbHarga
            // 
            this.lbHarga.AutoSize = true;
            this.lbHarga.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHarga.ForeColor = System.Drawing.Color.White;
            this.lbHarga.Location = new System.Drawing.Point(6, 125);
            this.lbHarga.Name = "lbHarga";
            this.lbHarga.Size = new System.Drawing.Size(48, 28);
            this.lbHarga.TabIndex = 23;
            this.lbHarga.Text = "Harga";
            // 
            // tbHarga
            // 
            this.tbHarga.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHarga.Location = new System.Drawing.Point(90, 122);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(160, 30);
            this.tbHarga.TabIndex = 22;
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNama.ForeColor = System.Drawing.Color.White;
            this.lbNama.Location = new System.Drawing.Point(6, 76);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(47, 28);
            this.lbNama.TabIndex = 21;
            this.lbNama.Text = "Nama";
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(90, 73);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(160, 30);
            this.tbNama.TabIndex = 20;
            // 
            // formMerek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 498);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.DataAlkohol);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.DataRokok);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btSimpan);
            this.Name = "formMerek";
            this.Load += new System.EventHandler(this.formMerek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataRokok)).EndInit();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataAlkohol)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btSimpan;
        private System.Windows.Forms.PictureBox btEdit;
        private System.Windows.Forms.DataGridView DataRokok;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox btMinimize;
        private System.Windows.Forms.PictureBox btClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DataAlkohol;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label lbHarga;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbTabel;
        private System.Windows.Forms.ComboBox cbTabel;
    }
}