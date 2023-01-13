using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Besar_1214081_1214085.model
{
    internal class M_Merek_Rokok
    {
        string nama, harga;
        public M_Merek_Rokok()
        {

        }

        public M_Merek_Rokok(string nama, string harga)
        {
            this.Nama = nama;
            this.Harga = harga;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Harga { get => harga; set => harga = value; }
    }
}
