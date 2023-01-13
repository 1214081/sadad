namespace Tugas_Besar_1214081_1214085.view
{
    partial class formEditAlkohol
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataAlkohol = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIDAlkohol = new System.Windows.Forms.TextBox();
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
            this.btEdit = new System.Windows.Forms.PictureBox();
            this.tbJumlahAlkohol = new System.Windows.Forms.TextBox();
            this.lbJumlahBotol = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataAlkohol)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btEdit)).BeginInit();
            this.SuspendLayout();
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
            this.Header.Size = new System.Drawing.Size(744, 52);
            this.Header.TabIndex = 17;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // btMinimize
            // 
            this.btMinimize.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Minimize__2_;
            this.btMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMinimize.Location = new System.Drawing.Point(625, 3);
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
            this.btClose.Location = new System.Drawing.Point(695, 3);
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
            this.DataAlkohol.Location = new System.Drawing.Point(12, 66);
            this.DataAlkohol.Name = "DataAlkohol";
            this.DataAlkohol.Size = new System.Drawing.Size(719, 150);
            this.DataAlkohol.TabIndex = 18;
            this.DataAlkohol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataAlkohol_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Controls.Add(this.tbIDAlkohol);
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
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.tbJumlahAlkohol);
            this.groupBox1.Controls.Add(this.lbJumlahBotol);
            this.groupBox1.Location = new System.Drawing.Point(12, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 232);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // tbIDAlkohol
            // 
            this.tbIDAlkohol.Location = new System.Drawing.Point(175, 108);
            this.tbIDAlkohol.Name = "tbIDAlkohol";
            this.tbIDAlkohol.Size = new System.Drawing.Size(100, 20);
            this.tbIDAlkohol.TabIndex = 25;
            this.tbIDAlkohol.Visible = false;
            this.tbIDAlkohol.TextChanged += new System.EventHandler(this.tbIDRokok_TextChanged);
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.ForeColor = System.Drawing.Color.White;
            this.lbNote.Location = new System.Drawing.Point(388, 116);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(40, 28);
            this.lbNote.TabIndex = 24;
            this.lbNote.Text = "Note";
            // 
            // tbNote
            // 
            this.tbNote.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNote.Location = new System.Drawing.Point(454, 113);
            this.tbNote.MaxLength = 300;
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(233, 104);
            this.tbNote.TabIndex = 23;
            this.tbNote.TextChanged += new System.EventHandler(this.tbNote_TextChanged);
            // 
            // tbIDMerek
            // 
            this.tbIDMerek.Location = new System.Drawing.Point(264, 134);
            this.tbIDMerek.Name = "tbIDMerek";
            this.tbIDMerek.Size = new System.Drawing.Size(100, 20);
            this.tbIDMerek.TabIndex = 22;
            this.tbIDMerek.Visible = false;
            // 
            // dtbTanggal
            // 
            this.dtbTanggal.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbTanggal.Location = new System.Drawing.Point(454, 65);
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
            this.lbTanggal.Location = new System.Drawing.Point(388, 69);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.Size = new System.Drawing.Size(59, 28);
            this.lbTanggal.TabIndex = 20;
            this.lbTanggal.Text = "Tanggal";
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(454, 19);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(233, 30);
            this.tbTotal.TabIndex = 19;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(388, 22);
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
            "Anggur Merah",
            "Newport",
            "Asoka"});
            this.cbMerek.Location = new System.Drawing.Point(147, 19);
            this.cbMerek.Name = "cbMerek";
            this.cbMerek.Size = new System.Drawing.Size(217, 35);
            this.cbMerek.TabIndex = 17;
            this.cbMerek.SelectedIndexChanged += new System.EventHandler(this.cbMerek_SelectedIndexChanged);
            // 
            // lbMerek
            // 
            this.lbMerek.AutoSize = true;
            this.lbMerek.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMerek.ForeColor = System.Drawing.Color.White;
            this.lbMerek.Location = new System.Drawing.Point(11, 22);
            this.lbMerek.Name = "lbMerek";
            this.lbMerek.Size = new System.Drawing.Size(49, 28);
            this.lbMerek.TabIndex = 15;
            this.lbMerek.Text = "Merek";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(184, 160);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(100, 20);
            this.tbHarga.TabIndex = 14;
            this.tbHarga.Visible = false;
            // 
            // btEdit
            // 
            this.btEdit.BackgroundImage = global::Tugas_Besar_1214081_1214085.Properties.Resources.Edit;
            this.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEdit.Location = new System.Drawing.Point(16, 173);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(124, 44);
            this.btEdit.TabIndex = 12;
            this.btEdit.TabStop = false;
            this.btEdit.Click += new System.EventHandler(this.btSimpan_Click);
            this.btEdit.MouseEnter += new System.EventHandler(this.btSimpan_MouseEnter);
            this.btEdit.MouseLeave += new System.EventHandler(this.btSimpan_MouseLeave);
            // 
            // tbJumlahAlkohol
            // 
            this.tbJumlahAlkohol.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJumlahAlkohol.Location = new System.Drawing.Point(147, 66);
            this.tbJumlahAlkohol.Name = "tbJumlahAlkohol";
            this.tbJumlahAlkohol.Size = new System.Drawing.Size(217, 30);
            this.tbJumlahAlkohol.TabIndex = 11;
            this.tbJumlahAlkohol.TextChanged += new System.EventHandler(this.tbJumlahAlkohol_TextChanged);
            // 
            // lbJumlahBotol
            // 
            this.lbJumlahBotol.AutoSize = true;
            this.lbJumlahBotol.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJumlahBotol.ForeColor = System.Drawing.Color.White;
            this.lbJumlahBotol.Location = new System.Drawing.Point(11, 69);
            this.lbJumlahBotol.Name = "lbJumlahBotol";
            this.lbJumlahBotol.Size = new System.Drawing.Size(99, 28);
            this.lbJumlahBotol.TabIndex = 9;
            this.lbJumlahBotol.Text = "Jumlah (Botol)";
            // 
            // formEditAlkohol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataAlkohol);
            this.Controls.Add(this.Header);
            this.KeyPreview = true;
            this.Name = "formEditAlkohol";
            this.Load += new System.EventHandler(this.formEditAlkohol_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formInputRokok_KeyDown);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataAlkohol)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox btMinimize;
        private System.Windows.Forms.PictureBox btClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DataAlkohol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIDAlkohol;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.TextBox tbIDMerek;
        private System.Windows.Forms.DateTimePicker dtbTanggal;
        private System.Windows.Forms.Label lbTanggal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ComboBox cbMerek;
        private System.Windows.Forms.Label lbMerek;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.PictureBox btEdit;
        private System.Windows.Forms.TextBox tbJumlahAlkohol;
        private System.Windows.Forms.Label lbJumlahBotol;
    }
}