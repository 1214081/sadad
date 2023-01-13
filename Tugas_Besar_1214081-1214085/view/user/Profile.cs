using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Tugas_Besar_1214081_1214085.controller;
using Tugas_Besar_1214081_1214085.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Tugas_Besar_1214081_1214085.formLogin;

namespace Tugas_Besar_1214081_1214085.view
{
    public partial class formProfile : Template
    {
        Koneksi koneksi = new Koneksi();
        public formProfile()
        {
            InitializeComponent();
            
            tbIDUser.Enabled = false;
        }
        public void Tampil1()
        {
            //Query Database
            DataRokok.DataSource = koneksi.ShowData("SELECT rokok.id, m_rokok.nama, jumlah, rokok.harga, tanggal FROM user JOIN rokok ON rokok.id_user = user.id JOIN m_rokok ON m_rokok.id = rokok.id_merek WHERE id_user='" + LoginInfo.IDUser + "' ORDER BY id ASC");

            //Mengubah nama header
            DataRokok.Columns[0].HeaderText = "ID";
            DataRokok.Columns[1].HeaderText = "Merek";
            DataRokok.Columns[2].HeaderText = "Jumlah (Bungkus)";
            DataRokok.Columns[3].HeaderText = "Harga";
            DataRokok.Columns[4].HeaderText = "Tanggal";
        }
        public void Tampil2()
        {
            //Query Database
            DataAlkohol.DataSource = koneksi.ShowData("SELECT alkohol.id, m_alkohol.nama, jumlah, alkohol.harga, tanggal FROM user JOIN alkohol ON alkohol.id_user = user.id JOIN m_alkohol ON m_alkohol.id = alkohol.id_merek WHERE id_user='" + LoginInfo.IDUser + "' ORDER BY id ASC");

            //Mengubah nama header
            DataAlkohol.Columns[0].HeaderText = "ID";
            DataAlkohol.Columns[1].HeaderText = "Merek";
            DataAlkohol.Columns[2].HeaderText = "Jumlah (Bungkus)";
            DataAlkohol.Columns[3].HeaderText = "Harga";
            DataAlkohol.Columns[4].HeaderText = "Tanggal";
        }
        private void formProfile_Load(object sender, EventArgs e)
        {
            Tampil1();
            Tampil2();
            GetJumlahRokok();
            GetJumlahAlkohol();
            GetKerugianRokok();
            GetKerugianAlkohol();
        }
        //Jumlah dan total
        public void GetJumlahRokok()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT SUM(jumlah) FROM rokok WHERE id_user = '" + LoginInfo.IDUser + "'");
            if (reader.Read())
            {
                tbJumlahRokok.Text = reader.GetString(0);
                tbJumlahRokok.Enabled = false;
            }
            else
            {
                tbJumlahRokok.Text = "";
                tbJumlahRokok.Enabled = false;
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void GetJumlahAlkohol()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT SUM(jumlah) FROM alkohol WHERE id_user = '" + LoginInfo.IDUser + "'");
            if (reader.Read())
            {
                tbJumlahAlkohol.Text = reader.GetString(0);
                tbJumlahAlkohol.Enabled = false;
            }
            else
            {
                tbJumlahAlkohol.Text = "";
                tbJumlahAlkohol.Enabled = false;
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void GetKerugianRokok()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT SUM(harga) FROM rokok WHERE id_user = '" + LoginInfo.IDUser + "'");
            if (reader.Read())
            {
                tbKerugianRokok.Text = reader.GetString(0);
                tbKerugianRokok.Enabled = false;
            }
            else
            {
                tbKerugianRokok.Text = "";
                tbKerugianRokok.Enabled = false;
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void GetKerugianAlkohol()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT SUM(harga) FROM alkohol WHERE id_user = '" + LoginInfo.IDUser + "'");
            if (reader.Read())
            {
                tbKerugianAlkohol.Text = reader.GetString(0);
                tbKerugianAlkohol.Enabled = false;
            }
            else
            {
                tbKerugianAlkohol.Text = "";
                tbKerugianAlkohol.Enabled = false;
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        //Note
        private void DataRokok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDRokok.Text = DataRokok.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void DataAlkohol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDAlkohol.Text = DataAlkohol.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        public void GetNoteRokok()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT Note FROM rokok WHERE id='" + tbIDRokok.Text + "'");
            if (reader.Read())
            {
                tbNote.Enabled = true;
                tbNote.Text = reader.GetString(0);
                tbNote.Enabled = false;
            }
            else
            {
                tbNote.Enabled = true;
                tbNote.Text = "";
                tbNote.Enabled = false;
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void GetNoteAlkohol()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT Note FROM alkohol WHERE id='" + tbIDAlkohol.Text + "'");
            if (reader.Read())
            {
                tbNote.Enabled = true;
                tbNote.Text = reader.GetString(0);
                tbNote.Enabled = false;
            }
            else
            {
                tbNote.Enabled = true;
                tbNote.Text = "";
                tbNote.Enabled = false;
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        private void tbIDRokok_TextChanged(object sender, EventArgs e)
        {
            GetNoteRokok();
        }
        private void tbIDAlkohol_TextChanged(object sender, EventArgs e)
        {
            GetNoteAlkohol();
        }





        /*----------------------------------------------Header----------------------------------------------*/
        //Moving form with pannel
        bool moving;
        Point offset;
        Point original;
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            Header.Capture = true;
            offset = MousePosition;
            original = this.Location;
        }
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (!moving)
                return;

            int x = original.X + MousePosition.X - offset.X;
            int y = original.Y + MousePosition.Y - offset.Y;

            this.Location = new Point(x, y);
        }
        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            Header.Capture = false;
        }





        /*----------------------------------------------Button----------------------------------------------*/
        //Minimize button
        private void btMinimize_MouseEnter(object sender, EventArgs e)
        {
            btMinimize.Size = new Size(36, 36);
            btMinimize.Location = new Point(630, 8);
        }
        private void btMinimize_MouseLeave(object sender, EventArgs e)
        {
            btMinimize.Size = new Size(46, 46);
            btMinimize.Location = new Point(625, 3);
        }
        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Close button
        private void btClose_MouseEnter(object sender, EventArgs e)
        {
            btClose.Size = new Size(36, 36);
            btClose.Location = new Point(700, 8);
        }
        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            btClose.Size = new Size(46, 46);
            btClose.Location = new Point(695, 3);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
