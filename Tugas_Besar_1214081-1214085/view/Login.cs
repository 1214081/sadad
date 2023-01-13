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
using Tugas_Besar_1214081_1214085.view;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Tugas_Besar_1214081_1214085.formLogin;

namespace Tugas_Besar_1214081_1214085
{
    public partial class formLogin : Template
    {
        Koneksi koneksi = new Koneksi();
        public formLogin()
        {
            InitializeComponent();
        }
        public static class LoginInfo
        {
            public static string IDUser;
        }
        public void GetIDUser()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.Reader("SELECT id FROM user WHERE username = '" + tbUsername.Text + "'");
            if (reader.Read())
            {
                tbIDUser.Text = reader.GetString(0);
            }
            else
            {
                tbIDUser.Text = "";
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            GetIDUser();
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
        //Close button
        private void btClose_MouseEnter(object sender, EventArgs e)
        {
            btClose.Size = new Size(36, 36);
            btClose.Location = new Point(663, 8);
        }
        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            btClose.Size = new Size(46, 46);
            btClose.Location = new Point(658, 3);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
        //Login button
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong !!!!");
            }
            else
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                Cek_Login login = new Cek_Login();
                M_User m_user = new M_User();
                bool statusAdmin = login.cekLoginAdmin(username, password);
                bool statusUser = login.cekLoginUser(username, password);
                if (statusAdmin)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    this.Hide();
                    formDashboardAdmin dashboardAdmin = new formDashboardAdmin();
                    dashboardAdmin.ShowDialog();
                    this.Close();
                }
                else if (statusUser)
                {
                    LoginInfo.IDUser = tbIDUser.Text;
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    this.Hide();
                    formDashboardUser dashboardUser = new formDashboardUser();
                    dashboardUser.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Gagal");
                }
            }
        }
        private void btLogin_MouseEnter(object sender, EventArgs e)
        {
            btLogin.Size = new Size(114, 34);
            btLogin.Location = new Point(15, 166);
        }
        private void btLogin_MouseLeave(object sender, EventArgs e)
        {
            btLogin.Size = new Size(124, 44);
            btLogin.Location = new Point(10, 161);
        }
        //Registrasi button
        private void btRegistrasi_Click(object sender, EventArgs e)
        {
            this.Hide();
            formRegistrasi registrasi = new formRegistrasi();
            registrasi.ShowDialog();
            this.Close();
        }
        private void btRegistrasi_MouseEnter(object sender, EventArgs e)
        {
            btRegistrasi.Size = new Size(114, 34);
            btRegistrasi.Location = new Point(236, 166);
        }
        private void btRegistrasi_MouseLeave(object sender, EventArgs e)
        {
            btRegistrasi.Size = new Size(124, 44);
            btRegistrasi.Location = new Point(231, 161);
        }





        /*----------------------------------------------Shortcut----------------------------------------------*/
        //Shortcut
        private void formLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbUsername.Text == "" || tbPassword.Text == "")
                {
                    MessageBox.Show("Username dan Password tidak boleh kosong !!!!");
                }
                else
                {
                    string username = tbUsername.Text;
                    LoginInfo.IDUser = tbIDUser.Text;
                    string password = tbPassword.Text;
                    Cek_Login login = new Cek_Login();
                    M_User m_user = new M_User();
                    bool statusAdmin = login.cekLoginAdmin(username, password);
                    bool statusUser = login.cekLoginUser(username, password);
                    if (statusAdmin)
                    {
                        MessageBox.Show("Login Berhasil", "Berhasil");
                        this.Hide();
                        formDashboardAdmin dashboardAdmin = new formDashboardAdmin();
                        dashboardAdmin.ShowDialog();
                        this.Close();
                    }
                    else if (statusUser)
                    {
                        MessageBox.Show("Login Berhasil", "Berhasil");
                        this.Hide();
                        formDashboardUser dashboardUser = new formDashboardUser();
                        dashboardUser.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Gagal Login", "Gagal");
                    }
                }
            }
        }
    }
}
