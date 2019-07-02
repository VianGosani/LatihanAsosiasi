using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAsosiasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kartu kartu = new Kartu();

            Karyawan karyawan = new Karyawan();
            karyawan.Nama = "Paijo";
            karyawan.Status = true;

            if (karyawan.Login(kartu))
            {
                Console.WriteLine("Data karyawan valid");
            }
            else
            {
                Console.WriteLine("Data karyawan tidak valid");
            }
            Console.ReadKey();
        }
    }
}
