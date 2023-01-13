using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_1214081_1214085.view.user;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static Tugas_Besar_1214081_1214085.formLogin;

namespace Tugas_Besar_1214081_1214085.view
{
    public partial class formDashboardUser : Template
    {
        public formDashboardUser()
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
        //Beranda1 button
        private void btBeranda1_MouseEnter(object sender, EventArgs e)
        {
            btBeranda1.Size = new Size(114, 34);
            btBeranda1.Location = new Point(124, 9);
        }
        private void btBeranda1_MouseLeave(object sender, EventArgs e)
        {
            btBeranda1.Size = new Size(124, 44);
            btBeranda1.Location = new Point(119, 4);
        }
        private void btBeranda1_Click(object sender, EventArgs e)
        {
            gb1.Visible = true;
            btAboutUs.Visible = true;
            btAboutUs.Enabled = true;
            btProfile.Visible = true;
            btProfile.Enabled = true;
            btLogout.Visible = true;
            btLogout.Enabled = true;
            btBeranda1.Visible = false;
            btBeranda1.Enabled = false;
            btBeranda2.Visible = true;
            btBeranda2.Enabled = true;
        }
        //Beranda2 button
        private void btBeranda2_MouseEnter(object sender, EventArgs e)
        {
            btBeranda2.Size = new Size(114, 34);
            btBeranda2.Location = new Point(124, 9);
        }
        private void btBeranda2_MouseLeave(object sender, EventArgs e)
        {
            btBeranda2.Size = new Size(124, 44);
            btBeranda2.Location = new Point(119, 4);
        }
        private void btBeranda2_Click(object sender, EventArgs e)
        {
            gb1.Visible = false;
            btAboutUs.Visible = false;
            btAboutUs.Enabled = false;
            btProfile.Visible = false;
            btProfile.Enabled = false;
            btLogout.Visible = false;
            btLogout.Enabled = false;
            btBeranda1.Visible = true;
            btBeranda1.Enabled = true;
            btBeranda2.Visible = false;
            btBeranda2.Enabled = false;
        }
        //About Us button
        private void btAboutUs_MouseEnter(object sender, EventArgs e)
        {
            btAboutUs.Size = new Size(114, 34);
            btAboutUs.Location = new Point(53, 15);
        }
        private void btAboutUs_MouseLeave(object sender, EventArgs e)
        {
            btAboutUs.Size = new Size(124, 44);
            btAboutUs.Location = new Point(48, 10);
        }
        private void btAboutUs_Click(object sender, EventArgs e)
        {
            formAboutUs aboutUs = new formAboutUs();
            aboutUs.MdiParent = this;
            aboutUs.Show();
        }
        //Profile button
        private void btProfile_MouseEnter(object sender, EventArgs e)
        {
            btProfile.Size = new Size(114, 34);
            btProfile.Location = new Point(53, 73);
        }
        private void btProfile_MouseLeave(object sender, EventArgs e)
        {
            btProfile.Size = new Size(124, 44);
            btProfile.Location = new Point(48, 68);
        }
        private void btProfile_Click(object sender, EventArgs e)
        {
            formProfile profile = new formProfile();
            profile.MdiParent = this;
            profile.Show();
        }
        //Logout button
        private void btLogout_MouseEnter(object sender, EventArgs e)
        {
            btLogout.Size = new Size(114, 34);
            btLogout.Location = new Point(53, 131);
        }
        private void btLogout_MouseLeave(object sender, EventArgs e)
        {
            btLogout.Size = new Size(124, 44);
            btLogout.Location = new Point(48, 126);
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
        //InputData1 button
        private void btInputData1_MouseEnter(object sender, EventArgs e)
        {
            btInputData1.Size = new Size(114, 34);
            btInputData1.Location = new Point(349, 9);
        }
        private void btInputData1_MouseLeave(object sender, EventArgs e)
        {
            btInputData1.Size = new Size(124, 44);
            btInputData1.Location = new Point(344, 4);
        }
        private void btInputData1_Click(object sender, EventArgs e)
        {
            gb2.Visible = true;
            btInputRokok.Visible = true;
            btInputRokok.Enabled = true;
            btInputAlkohol.Visible = true;
            btInputAlkohol.Enabled = true;
            btInputData1.Visible = false;
            btInputData1.Enabled = false;
            btInputData2.Visible = true;
            btInputData2.Enabled = true;
        }
        //InputData2 button
        private void btInputData2_MouseEnter(object sender, EventArgs e)
        {
            btInputData2.Size = new Size(114, 34);
            btInputData2.Location = new Point(349, 9);
        }
        private void btInputData2_MouseLeave(object sender, EventArgs e)
        {
            btInputData2.Size = new Size(124, 44);
            btInputData2.Location = new Point(344, 4);
        }
        private void btInputData2_Click(object sender, EventArgs e)
        {
            gb2.Visible = false;
            btInputRokok.Visible = false;
            btInputRokok.Enabled = false;
            btInputAlkohol.Visible = false;
            btInputAlkohol.Enabled = false;
            btInputData1.Visible = true;
            btInputData1.Enabled = true;
            btInputData2.Visible = false;
            btInputData2.Enabled = false;
        }
        //Input Rokok button
        private void btInputRokok_MouseEntser(object sender, EventArgs e)
        {
            btInputRokok.Size = new Size(114, 34);
            btInputRokok.Location = new Point(53, 15);
        }
        private void btInputRokok_MouseLeave(object sender, EventArgs e)
        {
            btInputRokok.Size = new Size(124, 44);
            btInputRokok.Location = new Point(48, 10);
        }
        private void btInputRokok_Click(object sender, EventArgs e)
        {
            formInputRokok iRokok = new formInputRokok();
            iRokok.MdiParent = this;
            iRokok.Show();
        }
        //Input Alkohol button
        private void btInputAlkohol_MouseEnter(object sender, EventArgs e)
        {
            btInputAlkohol.Size = new Size(114, 34);
            btInputAlkohol.Location = new Point(53, 73);
        }
        private void btInputAlkohol_MouseLeave(object sender, EventArgs e)
        {
            btInputAlkohol.Size = new Size(124, 44);
            btInputAlkohol.Location = new Point(48, 68);
        }
        private void btInputAlkohol_Click(object sender, EventArgs e)
        {
            formInputAlkohol iAlkohol = new formInputAlkohol();
            iAlkohol.MdiParent = this;
            iAlkohol.Show();
        }
        //EditData1 button
        private void btEditData1_MouseEnter(object sender, EventArgs e)
        {
            btEditData1.Size = new Size(114, 34);
            btEditData1.Location = new Point(574, 9);
        }
        private void btEditData1_MouseLeave(object sender, EventArgs e)
        {
            btEditData1.Size = new Size(124, 44);
            btEditData1.Location = new Point(569, 4);
        }
        private void btEditData1_Click(object sender, EventArgs e)
        {
            gb3.Visible = true;
            btEditRokok.Visible = true;
            btEditRokok.Enabled = true;
            btEditAlkohol.Visible = true;
            btEditAlkohol.Enabled = true;
            btEditData1.Visible = false;
            btEditData1.Enabled = false;
            btEditData2.Visible = true;
            btEditData2.Enabled = true;
        }
        //EditData2 button
        private void btEditData2_MouseEnter(object sender, EventArgs e)
        {
            btEditData2.Size = new Size(114, 34);
            btEditData2.Location = new Point(574, 9);
        }
        private void btEditData2_MouseLeave(object sender, EventArgs e)
        {
            btEditData2.Size = new Size(124, 44);
            btEditData2.Location = new Point(569, 4);
        }
        private void btEditData2_Click(object sender, EventArgs e)
        {
            gb3.Visible = false;
            btEditRokok.Visible = false;
            btEditRokok.Enabled = false;
            btEditAlkohol.Visible = false;
            btEditAlkohol.Enabled = false;
            btEditData1.Visible = true;
            btEditData1.Enabled = true;
            btEditData2.Visible = false;
            btEditData2.Enabled = false;
        }
        //Edit Rokok button
        private void btEditRokok_MouseEntser(object sender, EventArgs e)
        {
            btEditRokok.Size = new Size(114, 34);
            btEditRokok.Location = new Point(53, 15);
        }
        private void btEditRokok_MouseLeave(object sender, EventArgs e)
        {
            btEditRokok.Size = new Size(124, 44);
            btEditRokok.Location = new Point(48, 10);
        }
        private void btEditRokok_Click(object sender, EventArgs e)
        {
            formEditRokok eRokok = new formEditRokok();
            eRokok.MdiParent = this;
            eRokok.Show();
        }
        //Edit Alkohol button
        private void btEditAlkohol_MouseEnter(object sender, EventArgs e)
        {
            btEditAlkohol.Size = new Size(114, 34);
            btEditAlkohol.Location = new Point(53, 73);
        }
        private void btEditAlkohol_MouseLeave(object sender, EventArgs e)
        {
            btEditAlkohol.Size = new Size(124, 44);
            btEditAlkohol.Location = new Point(48, 68);
        }
        private void btEditAlkohol_Click(object sender, EventArgs e)
        {
            formEditAlkohol eAlkohol = new formEditAlkohol();
            eAlkohol.MdiParent = this;
            eAlkohol.Show();
        }
        //HapusData1 button
        private void btHapusData1_MouseEnter(object sender, EventArgs e)
        {
            btHapusData1.Size = new Size(114, 34);
            btHapusData1.Location = new Point(799, 9);
        }
        private void btHapusData1_MouseLeave(object sender, EventArgs e)
        {
            btHapusData1.Size = new Size(124, 44);
            btHapusData1.Location = new Point(794, 4);
        }
        private void btHapusData1_Click(object sender, EventArgs e)
        {
            gb4.Visible = true;
            btHapusRokok.Visible = true;
            btHapusRokok.Enabled = true;
            btHapusAlkohol.Visible = true;
            btHapusAlkohol.Enabled = true;
            btHapusData1.Visible = false;
            btHapusData1.Enabled = false;
            btHapusData2.Visible = true;
            btHapusData2.Enabled = true;
        }
        //HapusData2 button
        private void btHapusData2_MouseEnter(object sender, EventArgs e)
        {
            btHapusData2.Size = new Size(114, 34);
            btHapusData2.Location = new Point(799, 9);
        }
        private void btHapusData2_MouseLeave(object sender, EventArgs e)
        {
            btHapusData2.Size = new Size(124, 44);
            btHapusData2.Location = new Point(794, 4);
        }
        private void btHapusData2_Click(object sender, EventArgs e)
        {
            gb4.Visible = false;
            btHapusRokok.Visible = false;
            btHapusRokok.Enabled = false;
            btHapusAlkohol.Visible = false;
            btHapusAlkohol.Enabled = false;
            btHapusData1.Visible = true;
            btHapusData1.Enabled = true;
            btHapusData2.Visible = false;
            btHapusData2.Enabled = false;
        }
        //Hapus Rokok button
        private void btHapusRokok_MouseEntser(object sender, EventArgs e)
        {
            btHapusRokok.Size = new Size(114, 34);
            btHapusRokok.Location = new Point(53, 15);
        }
        private void btHapusRokok_MouseLeave(object sender, EventArgs e)
        {
            btHapusRokok.Size = new Size(124, 44);
            btHapusRokok.Location = new Point(48, 10);
        }
        private void btHapusRokok_Click(object sender, EventArgs e)
        {
            formHapusRokok hRokok = new formHapusRokok();
            hRokok.MdiParent = this;
            hRokok.Show();
        }
        //Hapus Alkohol button
        private void btHapusAlkohol_MouseEnter(object sender, EventArgs e)
        {
            btHapusAlkohol.Size = new Size(114, 34);
            btHapusAlkohol.Location = new Point(53, 73);
        }
        private void btHapusAlkohol_MouseLeave(object sender, EventArgs e)
        {
            btHapusAlkohol.Size = new Size(124, 44);
            btHapusAlkohol.Location = new Point(48, 68);
        }
        private void btHapusAlkoholl_Click(object sender, EventArgs e)
        {
            formHapusAlkohol hAlkohol = new formHapusAlkohol();
            hAlkohol.MdiParent = this;
            hAlkohol.Show();
        }
        //Contact button
        private void btContact_MouseEnter(object sender, EventArgs e)
        {
            btPesan.Size = new Size(114, 34);
            btPesan.Location = new Point(1024, 9);
        }
        private void btContact_MouseLeave(object sender, EventArgs e)
        {
            btPesan.Size = new Size(124, 44);
            btPesan.Location = new Point(1019, 4);
        }
        private void btContact_Click(object sender, EventArgs e)
        {
            formPesan contact = new formPesan();
            contact.MdiParent = this;
            contact.Show();
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
