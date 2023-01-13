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

namespace Tugas_Besar_1214081_1214085.view
{
    public partial class formEditRokok : Template
    {
        Koneksi koneksi = new Koneksi();
        M_Rokok m_rokok = new M_Rokok();
        string id;
        public formEditRokok()
        {
            InitializeComponent();
            koneksi.OpenConnection();
        }
        private void DataRokok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataRokok.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbIDRokok.Text = DataRokok.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbMerek.Text = DataRokok.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbJumlahRokok.Text = DataRokok.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbTotal.Text = DataRokok.Rows[e.RowIndex].Cells[3].Value.ToString();
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
        private void formEditRokok_Load(object sender, EventArgs e)
        {
            Tampil1();
        }
        private void tbJumlahRokok_TextChanged(object sender, EventArgs e)
        {
            tbTotal.Text = (float.Parse(tbHarga.Text) * float.Parse(tbJumlahRokok.Text)).ToString();
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
        public void GetNoteRokok()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT note FROM rokok WHERE id='" + tbIDRokok.Text + "'");
            if (reader.Read())
            {
                tbNote.Text = reader.GetString(0);
            }
            else
            {
                tbNote.Text = "";
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        private void tbIDRokok_TextChanged(object sender, EventArgs e)
        {
            GetNoteRokok();
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
            btEdit.Size = new Size(114, 34);
            btEdit.Location = new Point(21, 178);
        }
        private void btSimpan_MouseLeave(object sender, EventArgs e)
        {
            btEdit.Size = new Size(124, 44);
            btEdit.Location = new Point(16, 173);
        }
        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (cbMerek.SelectedIndex == -1 || tbJumlahRokok.Text == "" || tbTotal.Text == "" || tbNote.Text =="")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Metode mthd = new Metode();
                m_rokok.Id_merek = tbIDMerek.Text;
                m_rokok.Jumlah = tbJumlahRokok.Text;
                m_rokok.Harga = tbTotal.Text;
                m_rokok.Tanggal = dtbTanggal.Text;
                m_rokok.Note = tbNote.Text;

                mthd.UpdateRokok(m_rokok, id);

                this.Close();
            }
        }
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





        /*----------------------------------------------Shortcut----------------------------------------------*/
        //Shortcut button
        private void formInputRokok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbMerek.SelectedIndex == -1 || tbJumlahRokok.Text == "" || tbTotal.Text == "" || tbNote.Text == "")
                {
                    MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Metode mthd = new Metode();
                    m_rokok.Id_merek = tbIDMerek.Text;
                    m_rokok.Jumlah = tbJumlahRokok.Text;
                    m_rokok.Harga = tbTotal.Text;
                    m_rokok.Tanggal = dtbTanggal.Text;
                    m_rokok.Note = tbNote.Text;

                    mthd.UpdateRokok(m_rokok, id);

                    this.Close();
                }
            }
        }
    }
}
