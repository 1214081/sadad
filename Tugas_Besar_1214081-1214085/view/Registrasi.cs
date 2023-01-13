using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_1214081_1214085.model;
using Tugas_Besar_1214081_1214085.controller;
using Tugas_Besar_1214081_1214085.view;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using System.Threading;
using static Tugas_Besar_1214081_1214085.formLogin;
using MySql.Data.MySqlClient;

namespace Tugas_Besar_1214081_1214085
{
    public partial class formRegistrasi : Template
    {
        Koneksi koneksi = new Koneksi();
        M_User m_user = new M_User();
        public formRegistrasi()
        {
            InitializeComponent();
        }
        private void formRegistrasi_Load(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Close();
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
            this.Hide();
            formLogin login = new formLogin();
            login.ShowDialog();
            this.Close();
        }
        private void btLogin_MouseEnter(object sender, EventArgs e)
        {
            btLogin.Size = new Size(114, 34);
            btLogin.Location = new Point(15, 245);
        }
        private void btLogin_MouseLeave(object sender, EventArgs e)
        {
            btLogin.Size = new Size(124, 44);
            btLogin.Location = new Point(10, 240);
        }
        //Registrasi button
        private void btRegistrasi_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tbConfirmPassword.Text == tbPassword.Text)
                {
                    Metode mthd = new Metode();
                    m_user.Name = tbName.Text;
                    m_user.Username = tbUsername.Text;
                    m_user.Password = tbPassword.Text;


                    mthd.InsertRegistrasi(m_user);

                    tbName.Text = "";
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                    tbConfirmPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Password tidak sama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btRegistrasi_MouseEnter(object sender, EventArgs e)
        {
            btRegistrasi.Size = new Size(114, 34);
            btRegistrasi.Location = new Point(236, 245);
        }
        private void btRegistrasi_MouseLeave(object sender, EventArgs e)
        {
            btRegistrasi.Size = new Size(124, 44);
            btRegistrasi.Location = new Point(231, 240);
        }





        /*----------------------------------------------Shortcut----------------------------------------------*/
        //Shortcut button
        private void formRegistrasi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbName.Text == "" || tbUsername.Text == "" || tbPassword.Text == "")
                {
                    MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (tbConfirmPassword.Text == tbPassword.Text)
                    {
                        Metode mthd = new Metode();
                        m_user.Name = tbName.Text;
                        m_user.Username = tbUsername.Text;
                        m_user.Password = tbPassword.Text;


                        mthd.InsertRegistrasi(m_user);

                        tbName.Text = "";
                        tbUsername.Text = "";
                        tbPassword.Text = "";
                        tbConfirmPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Password tidak sama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
