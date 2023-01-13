using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tugas_Besar_1214081_1214085.formLogin;
using Tugas_Besar_1214081_1214085.controller;
using Tugas_Besar_1214081_1214085.model;

namespace Tugas_Besar_1214081_1214085.view.admin
{
    public partial class formMerek : Template
    {
        string id_merek_rokok;
        string id_merek_alkohol;
        Koneksi koneksi = new Koneksi();
        M_Merek_Rokok m_rokok = new M_Merek_Rokok();
        M_Merek_Alkohol m_alkohol = new M_Merek_Alkohol();
        public formMerek()
        {
            InitializeComponent();
        }
        private void DataRokok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_merek_rokok = DataRokok.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNama.Text = DataRokok.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbHarga.Text = DataRokok.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void DataAlkohol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_merek_alkohol = DataAlkohol.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNama.Text = DataAlkohol.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbHarga.Text = DataAlkohol.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void formMerek_Load(object sender, EventArgs e)
        {
            Tampil();
        }
        public void Tampil()
        {
            //Query Database
            DataRokok.DataSource = koneksi.ShowData("SELECT id,nama,harga FROM m_rokok ORDER BY id ASC");
            DataAlkohol.DataSource = koneksi.ShowData("SELECT id,nama,harga FROM m_alkohol ORDER BY id ASC");

            //Mengubah nama header
            DataRokok.Columns[0].HeaderText = "ID";
            DataRokok.Columns[1].HeaderText = "Nama";
            DataRokok.Columns[2].HeaderText = "Harga";

            DataAlkohol.Columns[0].HeaderText = "ID";
            DataAlkohol.Columns[1].HeaderText = "Nama";
            DataAlkohol.Columns[2].HeaderText = "Harga";
        }
        //Hapus
        private void DataRokok_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_merek_rokok = DataRokok.Rows[e.RowIndex].Cells[0].Value.ToString();
            DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin menghapus data", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Metode mthd = new Metode();
                mthd.DeleteMerekRokok(id_merek_rokok);
                Tampil();
            }
        }
        private void DataAlkohol_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_merek_alkohol = DataRokok.Rows[e.RowIndex].Cells[0].Value.ToString();
            DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin menghapus data", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Metode mthd = new Metode();
                mthd.DeleteMerekAlkohol(id_merek_alkohol);
                Tampil();
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
        //Simpan Button
        private void btSimpan_MouseEnter(object sender, EventArgs e)
        {
            btSimpan.Size = new Size(114, 34);
            btSimpan.Location = new Point(311, 331);
        }
        private void btSimpan_MouseLeave(object sender, EventArgs e)
        {
            btSimpan.Size = new Size(124, 44);
            btSimpan.Location = new Point(306, 326);
        }
        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || tbHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Metode mthd = new Metode();
                if (cbTabel.SelectedIndex == 1)
                {
                    m_rokok.Nama = tbNama.Text;
                    m_rokok.Harga = tbHarga.Text;
                    mthd.InputMerekRokok(m_rokok);
                }
                else if (cbTabel.SelectedIndex == 2)
                {
                    m_alkohol.Nama = tbNama.Text;
                    m_alkohol.Harga = tbHarga.Text;
                    mthd.InputMerekAlkohol(m_alkohol);
                }
                Tampil();
            }
        }
        //Edit button
        private void btEdit_MouseEnter(object sender, EventArgs e)
        {
            btEdit.Size = new Size(114, 34);
            btEdit.Location = new Point(311, 389);
        }
        private void btEdit_MouseLeave(object sender, EventArgs e)
        {
            btEdit.Size = new Size(124, 44);
            btEdit.Location = new Point(306, 384);
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (cbTabel.SelectedIndex == -1 || tbNama.Text == "" || tbHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Metode mthd = new Metode();
                if (cbTabel.SelectedIndex == 0)
                {
                    m_rokok.Nama = tbNama.Text;
                    m_rokok.Harga = tbHarga.Text;
                    mthd.UpdateMerekRokok(m_rokok, id_merek_rokok);
                }
                else if (cbTabel.SelectedIndex == 1)
                {
                    m_alkohol.Nama = tbNama.Text;
                    m_alkohol.Harga = tbHarga.Text;
                    mthd.UpdateMerekAlkohol(m_alkohol, id_merek_alkohol);
                }
                Tampil();
            }
        }
        //Minimize button
        private void btMinimize_MouseEnter(object sender, EventArgs e)
        {
            btMinimize.Size = new Size(36, 36);
            btMinimize.Location = new Point(328, 8);
        }
        private void btMinimize_MouseLeave(object sender, EventArgs e)
        {
            btMinimize.Size = new Size(46, 46);
            btMinimize.Location = new Point(323, 3);
        }
        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Close button
        private void btClose_MouseEnter(object sender, EventArgs e)
        {
            btClose.Size = new Size(36, 36);
            btClose.Location = new Point(398, 8);
        }
        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            btClose.Size = new Size(46, 46);
            btClose.Location = new Point(393, 3);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
