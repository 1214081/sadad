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
using System.Xml.Linq;
using Tugas_Besar_1214081_1214085.controller;
using Tugas_Besar_1214081_1214085.model;
using static Tugas_Besar_1214081_1214085.formLogin;

namespace Tugas_Besar_1214081_1214085.view
{
    public partial class formInputRokok : Template
    {
        Koneksi koneksi = new Koneksi();
        M_Rokok m_rokok = new M_Rokok();
        public formInputRokok()
        {
            InitializeComponent();
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT name FROM user WHERE id = '" + LoginInfo.IDUser + "'");
            if (reader.Read())
            {
                tbNama.Text = reader.GetString(0);
                tbNama.Enabled = false;
            }
            else
            {
                tbNama.Text = "";
                tbNama.Enabled = false;
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        private void tbJumlahRokok_TextChanged(object sender, EventArgs e)
        {
            tbTotal.Enabled = true;
            tbTotal.Text = (float.Parse(tbHarga.Text) * float.Parse(tbJumlahRokok.Text)).ToString();
            tbTotal.Enabled = false;
        }
        public void GetHargaMerek()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT harga,id FROM m_rokok WHERE nama = '" + cbMerek.Text + "'");
            if (reader.Read())
            {
                tbHarga.Text = reader.GetString(0);
                tbIDMerek.Text = reader.GetString(1);
            }
            else
            {
                tbHarga.Text = "";
                tbHarga.Text = "";
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        private void cbMerek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMerek.SelectedIndex == -1)
            {

            }
            else
            {
                cbMerek.Enabled = false;
                GetHargaMerek();
                tbJumlahRokok.Enabled = true;
            }
        }
        private void tbNote_TextChanged(object sender, EventArgs e)
        {
            if (tbNote.TextLength > 299)
            {
                MessageBox.Show("Kata tidak boleh melebihi 300 karakter", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
        //Simpan button
        private void btSimpan_MouseEnter(object sender, EventArgs e)
        {
            btSimpan.Size = new Size(114, 34);
            btSimpan.Location = new Point(16, 396);
        }
        private void btSimpan_MouseLeave(object sender, EventArgs e)
        {
            btSimpan.Size = new Size(124, 44);
            btSimpan.Location = new Point(11, 391);
        }
        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || cbMerek.SelectedIndex == -1 || tbJumlahRokok.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Metode mthd = new Metode();
                m_rokok.Id_user = LoginInfo.IDUser;
                m_rokok.Id_merek = tbIDMerek.Text;
                m_rokok.Jumlah = tbJumlahRokok.Text;
                m_rokok.Harga = tbTotal.Text;
                m_rokok.Tanggal = dtbTanggal.Text;
                m_rokok.Note = tbNote.Text;


                mthd.InputRokok(m_rokok);

                this.Close();
            }
        }
        //Minimize button
        private void btMinimize_MouseEnter(object sender, EventArgs e)
        {
            btMinimize.Size = new Size(36, 36);
            btMinimize.Location = new Point(315, 8);
        }
        private void btMinimize_MouseLeave(object sender, EventArgs e)
        {
            btMinimize.Size = new Size(46, 46);
            btMinimize.Location = new Point(310, 3);
        }
        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Close button
        private void btClose_MouseEnter(object sender, EventArgs e)
        {
            btClose.Size = new Size(36, 36);
            btClose.Location = new Point(385, 8);
        }
        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            btClose.Size = new Size(46, 46);
            btClose.Location = new Point(380, 3);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        /*----------------------------------------------Shortcut----------------------------------------------*/
        //Shortcut button
        private void formInputRokok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbNama.Text == "" || cbMerek.SelectedIndex == -1 || tbJumlahRokok.Text == "" || tbTotal.Text == "")
                {
                    MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Metode mthd = new Metode();
                    m_rokok.Id_user = LoginInfo.IDUser;
                    m_rokok.Id_merek = tbIDMerek.Text;
                    m_rokok.Jumlah = tbJumlahRokok.Text;
                    m_rokok.Harga = tbTotal.Text;
                    m_rokok.Tanggal = dtbTanggal.Text;
                    m_rokok.Note = tbNote.Text;


                    mthd.InputRokok(m_rokok);

                    this.Close();
                }
            }
        }
    }
}
