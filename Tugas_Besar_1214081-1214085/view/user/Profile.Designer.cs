namespace Tugas_Besar_1214081_1214085.view
{
    partial class formProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbKerugianRokok = new System.Windows.Forms.Label();
            this.lbJumlahAlkohol = new System.Windows.Forms.Label();
            this.lbJumlahRokok = new System.Windows.Forms.Label();
            this.lbAlkohol = new System.Windows.Forms.Label();
            this.lbRokok = new System.Windows.Forms.Label();
            this.DataAlkohol = new System.Windows.Forms.DataGridView();
            this.DataRokok = new System.Windows.Forms.DataGridView();
            this.tbIDUser = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.Panel();
            this.btMinimize = new System.Windows.Forms.PictureBox();
            this.btClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbJumlahRokok = new System.Windows.Forms.TextBox();
            this.tbKerugianRokok = new System.Windows.Forms.TextBox();
            this.tbJumlahAlkohol = new System.Windows.Forms.TextBox();
            this.tbKerugianAlkohol = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.tbIDRokok = new System.Windows.Forms.TextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.tbIDAlkohol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataAlkohol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataRokok)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kerugian (Rp)";
            // 
            // lbKerugianRokok
            // 
            this.lbKerugianRokok.AutoSize = true;
            this.lbKerugianRokok.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKerugianRokok.Location = new System.Drawing.Point(12, 447);
            this.lbKerugianRokok.Name = "lbKerugianRokok";
            this.lbKerugianRokok.Size = new System.Drawing.Size(96, 28);
            this.lbKerugianRokok.TabIndex = 6;
            this.lbKerugianRokok.Text = "Kerugian (Rp)";
            // 
            // lbJumlahAlkohol
            // 
            this.lbJumlahAlkohol.AutoSize = true;
            this.lbJumlahAlkohol.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJumlahAlkohol.Location = new System.Drawing.Point(444, 402);
            this.lbJumlahAlkohol.Name = "lbJumlahAlkohol";
            this.lbJumlahAlkohol.Size = new System.Drawing.Size(99, 28);
            this.lbJumlahAlkohol.TabIndex = 5;
            this.lbJumlahAlkohol.Text = "Jumlah (Botol)";
            // 
            // lbJumlahRokok
            // 
            this.lbJumlahRokok.AutoSize = true;
            this.lbJumlahRokok.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJumlahRokok.Location = new System.Drawing.Point(12, 402);
            this.lbJumlahRokok.Name = "lbJumlahRokok";
            this.lbJumlahRokok.Size = new System.Drawing.Size(120, 28);
            this.lbJumlahRokok.TabIndex = 4;
            this.lbJumlahRokok.Text = "Jumlah (Bungkus)";
            // 
            // lbAlkohol
            // 
            this.lbAlkohol.AutoSize = true;
            this.lbAlkohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlkohol.Location = new System.Drawing.Point(443, 379);
            this.lbAlkohol.Name = "lbAlkohol";
            this.lbAlkohol.Size = new System.Drawing.Size(68, 20);
            this.lbAlkohol.TabIndex = 3;
            this.lbAlkohol.Text = "Alkohol";
            // 
            // lbRokok
            // 
            this.lbRokok.AutoSize = true;
            this.lbRokok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRokok.Location = new System.Drawing.Point(12, 379);
            this.lbRokok.Name = "lbRokok";
            this.lbRokok.Size = new System.Drawing.Size(60, 20);
            this.lbRokok.TabIndex = 2;
            this.lbRokok.Text = "Rokok";
            // 
            // DataAlkohol
            // 
            this.DataAlkohol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataAlkohol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAlkohol.Location = new System.Drawing.Point(12, 222);
            this.DataAlkohol.Name = "DataAlkohol";
            this.DataAlkohol.Size = new System.Drawing.Size(719, 150);
            this.DataAlkohol.TabIndex = 1;
            this.DataAlkohol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataAlkohol_CellClick);
            // 
            // DataRokok
            // 
            this.DataRokok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataRokok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataRokok.Location = new System.Drawing.Point(12, 66);
            this.DataRokok.Name = "DataRokok";
            this.DataRokok.Size = new System.Drawing.Size(719, 150);
            this.DataRokok.TabIndex = 0;
            this.DataRokok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataRokok_CellClick);
            // 
            // tbIDUser
            // 
            this.tbIDUser.Location = new System.Drawing.Point(227, 373);
            this.tbIDUser.Name = "tbIDUser";
            this.tbIDUser.Size = new System.Drawing.Size(100, 20);
            this.tbIDUser.TabIndex = 14;
            this.tbIDUser.Visible = false;
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
            this.Header.TabIndex = 15;
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
            // tbJumlahRokok
            // 
            this.tbJumlahRokok.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJumlahRokok.Location = new System.Drawing.Point(138, 399);
            this.tbJumlahRokok.Name = "tbJumlahRokok";
            this.tbJumlahRokok.Size = new System.Drawing.Size(165, 30);
            this.tbJumlahRokok.TabIndex = 16;
            // 
            // tbKerugianRokok
            // 
            this.tbKerugianRokok.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKerugianRokok.Location = new System.Drawing.Point(138, 444);
            this.tbKerugianRokok.Name = "tbKerugianRokok";
            this.tbKerugianRokok.Size = new System.Drawing.Size(165, 30);
            this.tbKerugianRokok.TabIndex = 17;
            // 
            // tbJumlahAlkohol
            // 
            this.tbJumlahAlkohol.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJumlahAlkohol.Location = new System.Drawing.Point(566, 399);
            this.tbJumlahAlkohol.Name = "tbJumlahAlkohol";
            this.tbJumlahAlkohol.Size = new System.Drawing.Size(165, 30);
            this.tbJumlahAlkohol.TabIndex = 18;
            // 
            // tbKerugianAlkohol
            // 
            this.tbKerugianAlkohol.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKerugianAlkohol.Location = new System.Drawing.Point(566, 444);
            this.tbKerugianAlkohol.Name = "tbKerugianAlkohol";
            this.tbKerugianAlkohol.Size = new System.Drawing.Size(165, 30);
            this.tbKerugianAlkohol.TabIndex = 19;
            // 
            // tbNote
            // 
            this.tbNote.Enabled = false;
            this.tbNote.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNote.Location = new System.Drawing.Point(17, 523);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(714, 116);
            this.tbNote.TabIndex = 20;
            // 
            // tbIDRokok
            // 
            this.tbIDRokok.Location = new System.Drawing.Point(333, 373);
            this.tbIDRokok.Name = "tbIDRokok";
            this.tbIDRokok.Size = new System.Drawing.Size(100, 20);
            this.tbIDRokok.TabIndex = 21;
            this.tbIDRokok.TextChanged += new System.EventHandler(this.tbIDRokok_TextChanged);
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(349, 491);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(47, 20);
            this.lbNote.TabIndex = 22;
            this.lbNote.Text = "Note";
            // 
            // tbIDAlkohol
            // 
            this.tbIDAlkohol.Location = new System.Drawing.Point(333, 399);
            this.tbIDAlkohol.Name = "tbIDAlkohol";
            this.tbIDAlkohol.Size = new System.Drawing.Size(100, 20);
            this.tbIDAlkohol.TabIndex = 23;
            this.tbIDAlkohol.TextChanged += new System.EventHandler(this.tbIDAlkohol_TextChanged);
            // 
            // formProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 648);
            this.Controls.Add(this.tbIDAlkohol);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.tbIDRokok);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbKerugianAlkohol);
            this.Controls.Add(this.tbJumlahAlkohol);
            this.Controls.Add(this.tbKerugianRokok);
            this.Controls.Add(this.tbJumlahRokok);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.tbIDUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKerugianRokok);
            this.Controls.Add(this.lbJumlahAlkohol);
            this.Controls.Add(this.lbJumlahRokok);
            this.Controls.Add(this.lbAlkohol);
            this.Controls.Add(this.lbRokok);
            this.Controls.Add(this.DataAlkohol);
            this.Controls.Add(this.DataRokok);
            this.Name = "formProfile";
            this.Load += new System.EventHandler(this.formProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataAlkohol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataRokok)).EndInit();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataRokok;
        private System.Windows.Forms.DataGridView DataAlkohol;
        private System.Windows.Forms.Label lbRokok;
        private System.Windows.Forms.Label lbAlkohol;
        private System.Windows.Forms.Label lbJumlahRokok;
        private System.Windows.Forms.Label lbJumlahAlkohol;
        private System.Windows.Forms.Label lbKerugianRokok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIDUser;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbJumlahRokok;
        private System.Windows.Forms.TextBox tbKerugianRokok;
        private System.Windows.Forms.TextBox tbJumlahAlkohol;
        private System.Windows.Forms.TextBox tbKerugianAlkohol;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.TextBox tbIDRokok;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.TextBox tbIDAlkohol;
        private System.Windows.Forms.PictureBox btMinimize;
        private System.Windows.Forms.PictureBox btClose;
    }
}