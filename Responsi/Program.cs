using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            //konstruktor
            Karyawan kyw = new Karyawan("12345", "Vian", 3000000);
            Karyawan kyw2 = new Karyawan("67890", "Gosani", -200000);

            Hasil(kyw,kyw2);

            Console.WriteLine("Asyiiiiikkkk Kenaikan Gaji 10%");
            Console.WriteLine(); 

            double naik = (0.10 * kyw.GajiBulanan) + kyw.GajiBulanan;
            double naik2 = (0.10 * kyw2.GajiBulanan) + kyw2.GajiBulanan;
            kyw.GajiBulanan = Convert.ToInt32(naik);
            kyw2.GajiBulanan = Convert.ToInt32(naik2);

            Hasil(kyw,kyw2);

            Console.ReadKey();
        }
        static void Hasil(Karyawan kyw, Karyawan kyw2)
        {
            Console.WriteLine("No Nik/Nama\tGaji Bulanan");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("1. ");
            Console.Write("{0} {1}", kyw.Nik, kyw.Nama);
            Console.Write("\t{0}", kyw.GajiBulanan);
            Console.WriteLine();
            Console.Write("2. ");
            Console.Write("{0} {1}", kyw2.Nik, kyw2.Nama);
            Console.WriteLine("\t{0}", kyw2.GajiBulanan);
            Console.WriteLine();
        }
    }
}
