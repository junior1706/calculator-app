using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek_Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ulang;

            do
            {

                Console.Title = "Kalkulator";

                //Pilihan Operator
                Console.WriteLine("Pilihan : ");
                Console.WriteLine("1.Penjumlahan");
                Console.WriteLine("2.Pengurangan");
                Console.WriteLine("3.Perkalian");
                Console.WriteLine("4.Pembagian");

                //Inputan Operator
                Console.WriteLine("Masukan pilihan [1-4] : ");
                int pilihan = int.Parse(Console.ReadLine());


                double angka1, angka2, hasil;

                
                //
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Masukan Angka : ");
                        angka1 = double.Parse(Console.ReadLine());
                        angka2 = double.Parse(Console.ReadLine());
                        hasil = angka1 + angka2;
                        Console.WriteLine("Hasil : " + hasil);
                        break;
                    case 2:
                        Console.WriteLine("Masukan Angka : ");
                        angka1 = double.Parse(Console.ReadLine());
                        angka2 = double.Parse(Console.ReadLine());
                        hasil = angka1 - angka2;
                        Console.WriteLine("Hasil : " + hasil);
                        break;
                    case 3:
                        Console.WriteLine("Masukan Angka : ");
                        angka1 = double.Parse(Console.ReadLine());
                        angka2 = double.Parse(Console.ReadLine());
                        hasil = angka1 * angka2;
                        Console.WriteLine("Hasil : " + hasil);
                        break;
                    case 4:
                        Console.WriteLine("Masukan Angka : ");
                        angka1 = double.Parse(Console.ReadLine());
                        angka2 = double.Parse(Console.ReadLine());
                        if (angka2 != 0)
                        {
                            hasil = angka1 / angka2;
                            Console.WriteLine("Hasil : " + hasil);
                        }
                        else
                        {
                            Console.WriteLine("Tidak dapat dibagi dengan nol!");
                        }
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak ada!");
                        break;
                }

                //Perulangan Program
                Console.WriteLine("Apakah anda ingin mengulang? (y/n)");
                string jawaban = Console.ReadLine().ToLower();
                ulang = (jawaban == "y");

            } while (ulang);
        }
    }
}
