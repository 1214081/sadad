using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Besar_1214081_1214085.model
{
    internal class M_Pesan
    {
        string id_user, pesan_user, pesan_admin;
        public M_Pesan()
        {

        }

        public M_Pesan(string id_user, string pesan_user, string pesan_admin)
        {
            this.Id_user = id_user;
            this.Pesan_user = pesan_user;
            this.Pesan_admin = pesan_admin;
        }

        public string Id_user { get => id_user; set => id_user = value; }
        public string Pesan_user { get => pesan_user; set => pesan_user = value; }
        public string Pesan_admin { get => pesan_admin; set => pesan_admin = value; }
    }
}
