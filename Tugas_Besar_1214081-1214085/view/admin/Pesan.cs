using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_1214081_1214085.controller;
using Tugas_Besar_1214081_1214085.model;
using static Tugas_Besar_1214081_1214085.formLogin;

namespace Tugas_Besar_1214081_1214085.view.admin
{
    public partial class formPesan : Template
    {
        Koneksi koneksi = new Koneksi();
        M_Pesan m_pesan = new M_Pesan();
        string id;
        string nama;
        public formPesan()
        {
            InitializeComponent();
        }
        public void Tampil()
        {
            //Query Database
            DataPesan.DataSource = koneksi.ShowData("SELECT user.name,pesan_user,pesan_admin,tanggal FROM pesan JOIN user ON pesan.id_user = user.id ORDER BY pesan.id ASC");

            //Mengubah nama header
            DataPesan.Columns[0].HeaderText = "";
            DataPesan.Columns[1].HeaderText = "User";
            DataPesan.Columns[2].HeaderText = "Admin";
            DataPesan.Columns[3].HeaderText = "Waktu";
        }
        private void formPesan_Load(object sender, EventArgs e)
        {
            Tampil();
        }
        private void DataPesan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nama = DataPesan.Rows[e.RowIndex].Cells[0].Value.ToString();
            GetIDUser();
        }
        public void GetIDUser()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT id FROM user WHERE name = '" + nama + "'");
            if (reader.Read())
            {
                id = reader.GetString(0);
            }
            else
            {
                id = "";
            }
            reader.Close();
            koneksi.CloseConnection();
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
            btMinimize.Location = new Point(280, 8);
        }
        private void btMinimize_MouseLeave(object sender, EventArgs e)
        {
            btMinimize.Size = new Size(46, 46);
            btMinimize.Location = new Point(275, 3);
        }
        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Close button
        private void btClose_MouseEnter(object sender, EventArgs e)
        {
            btClose.Size = new Size(36, 36);
            btClose.Location = new Point(350, 8);
        }
        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            btClose.Size = new Size(46, 46);
            btClose.Location = new Point(345, 3);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Kirim button
        private void btKirim_MouseEnter(object sender, EventArgs e)
        {
            btKirim.Size = new Size(26, 26);
            btKirim.Location = new Point(354, 446);
        }
        private void btKirim_MouseLeave(object sender, EventArgs e)
        {
            btKirim.Size = new Size(30, 30);
            btKirim.Location = new Point(352, 444);
        }
        private void btKirim_Click(object sender, EventArgs e)
        {
            if (tbPesan.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Metode mthd = new Metode();
                m_pesan.Id_user = id;
                m_pesan.Pesan_admin = tbPesan.Text;

                mthd.InputPesanAdmin(m_pesan);

                Tampil();
            }
        }





        /*----------------------------------------------Shortcut----------------------------------------------*/
        //Shortcut button
        private void formPesan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPesan.Text == "")
                {
                    MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Metode mthd = new Metode();
                    m_pesan.Id_user = id;
                    m_pesan.Pesan_admin = tbPesan.Text;

                    mthd.InputPesanAdmin(m_pesan);

                    Tampil();
                }
            }
        }
    }
}
