using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Besar_1214081_1214085.model
{
    internal class M_Alkohol
    {
        string id_user, id_merek, jumlah, harga, tanggal, note;
        public M_Alkohol()
        {

        }

        public M_Alkohol(string id_user, string id_merek, string jumlah, string harga, string tanggal, string note)
        {
            this.Id_user = id_user;
            this.Id_merek = id_merek;
            this.Jumlah = jumlah;
            this.Harga = harga;
            this.Tanggal = tanggal;
            this.Note = note;
        }

        public string Id_user { get => id_user; set => id_user = value; }
        public string Id_merek { get => id_merek; set => id_merek = value; }
        public string Jumlah { get => jumlah; set => jumlah = value; }
        public string Harga { get => harga; set => harga = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
        public string Note { get => note; set => note = value; }
    }
}
