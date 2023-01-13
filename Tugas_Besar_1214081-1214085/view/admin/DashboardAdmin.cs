using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_1214081_1214085.view.admin;

namespace Tugas_Besar_1214081_1214085.view
{
    public partial class formDashboardAdmin : Template
    {
        public formDashboardAdmin()
        {
            InitializeComponent();
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
        //Merek button
        private void btMerek_MouseEnter(object sender, EventArgs e)
        {
            btMerek.Size = new Size(114, 34);
            btMerek.Location = new Point(124, 9);
        }
        private void btMerek_MouseLeave(object sender, EventArgs e)
        {
            btMerek.Size = new Size(124, 44);
            btMerek.Location = new Point(119, 4);
        }
        private void btMerek_Click(object sender, EventArgs e)
        {
            formMerek merek = new formMerek();
            merek.MdiParent = this;
            merek.Show();
        }
        //Pesan button
        private void btPesan_MouseEnter(object sender, EventArgs e)
        {
            btPesan.Size = new Size(114, 34);
            btPesan.Location = new Point(349, 9);
        }
        private void btPesan_MouseLeave(object sender, EventArgs e)
        {
            btPesan.Size = new Size(124, 44);
            btPesan.Location = new Point(344, 4);
        }
        private void btPesan_Click(object sender, EventArgs e)
        {
            formPesan pesan = new formPesan();
            pesan.MdiParent = this;
            pesan.Show();
        }
        //Logout button
        private void btLogout_MouseEnter(object sender, EventArgs e)
        {
            btLogout.Size = new Size(114, 34);
            btLogout.Location = new Point(574, 9);
        }
        private void btLogout_MouseLeave(object sender, EventArgs e)
        {
            btPesan.Size = new Size(124, 44);
            btPesan.Location = new Point(569, 4);
        }
        private void btLogout_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin logout", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                this.Hide();
                formLogin login = new formLogin();
                login.ShowDialog();
                this.Close();
            }
        }
        //Minimize button
        private void btMinimize_MouseEnter(object sender, EventArgs e)
        {
            btMinimize.Size = new Size(36, 36);
            btMinimize.Location = new Point(1250, 8);
        }
        private void btMinimize_MouseLeave(object sender, EventArgs e)
        {
            btMinimize.Size = new Size(46, 46);
            btMinimize.Location = new Point(1245, 3);
        }
        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Close button
        private void btClose_MouseEnter(object sender, EventArgs e)
        {
            btClose.Size = new Size(36, 36);
            btClose.Location = new Point(1320, 8);
        }
        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            btClose.Size = new Size(46, 46);
            btClose.Location = new Point(1315, 3);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
