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
    public partial class formEditAlkohol : Template
    {
        Koneksi koneksi = new Koneksi();
        M_Alkohol m_alkohol = new M_Alkohol();
        string id;
        public formEditAlkohol()
        {
            InitializeComponent();
        }
        private void DataAlkohol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataAlkohol.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbIDAlkohol.Text = DataAlkohol.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbMerek.Text = DataAlkohol.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbJumlahAlkohol.Text = DataAlkohol.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbTotal.Text = DataAlkohol.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        public void Tampil1()
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
        private void formEditAlkohol_Load(object sender, EventArgs e)
        {
            Tampil1();
        }
        private void tbJumlahAlkohol_TextChanged(object sender, EventArgs e)
        {
            tbTotal.Text = (float.Parse(tbHarga.Text) * float.Parse(tbJumlahAlkohol.Text)).ToString();
        }
        public void GetHargaMerek()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT harga,id FROM m_alkohol WHERE nama = '" + cbMerek.Text + "'");
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
                tbJumlahAlkohol.Enabled = true;
            }
        }
        private void tbNote_TextChanged(object sender, EventArgs e)
        {
            if (tbNote.TextLength > 299)
            {
                MessageBox.Show("Kata tidak boleh melebihi 300 karakter", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void GetNoteAlkohol()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT note FROM alkohol WHERE id='" + tbIDAlkohol.Text + "'");
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
            if (cbMerek.SelectedIndex == -1 || tbJumlahAlkohol.Text == "" || tbTotal.Text == "" || tbNote.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Metode mthd = new Metode();
                m_alkohol.Id_merek = tbIDMerek.Text;
                m_alkohol.Jumlah = tbJumlahAlkohol.Text;
                m_alkohol.Harga = tbTotal.Text;
                m_alkohol.Tanggal = dtbTanggal.Text;
                m_alkohol.Note = tbNote.Text;

                mthd.UpdateAlkohol(m_alkohol, id);

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
                if (cbMerek.SelectedIndex == -1 || tbJumlahAlkohol.Text == "" || tbTotal.Text == "" || tbNote.Text == "")
                {
                    MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Metode mthd = new Metode();
                    m_alkohol.Id_merek = tbIDMerek.Text;
                    m_alkohol.Jumlah = tbJumlahAlkohol.Text;
                    m_alkohol.Harga = tbTotal.Text;
                    m_alkohol.Tanggal = dtbTanggal.Text;
                    m_alkohol.Note = tbNote.Text;

                    mthd.UpdateAlkohol(m_alkohol, id);

                    this.Close();
                }
            }
        }
    }
}
