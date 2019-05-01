using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    class Karyawan
    {
        //properti karyawan
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(string nik, string nama, int gajibulanan) //konstruktor dengan parameter
        {
            Nik = nik;
            Nama = nama;
            GajiBulanan = gajibulanan;
            //validasi gaji kurang dari 0
            if (gajibulanan < 0)
            {
                GajiBulanan = 0;
            }
        }
    }
}
