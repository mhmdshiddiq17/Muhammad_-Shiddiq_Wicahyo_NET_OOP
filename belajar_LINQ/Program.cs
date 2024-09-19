using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belajar_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] bootcamp = { "Andi", "Sugeng", "Joko", "Wilson" };
            //var query = from n in bootcamp select n;
            //foreach(string peserta in query)
            //{
            //    Console.WriteLine(peserta);
            //}
            // tebakan angka 

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var query = from n in numbers where n > 5 orderby n descending select n;
            //foreach(var item in query)
            //{
            //    Console.WriteLine(item);
            //}
            Random random = new Random();
            int angkaTebakan = random.Next(1, 10); // Angka acak antara 1 dan 10
            int tebakanPengguna = 0;
            int jumlahCoba = 0;

            Console.WriteLine("Selamat datang di permainan tebak-tebakan angka!");
            Console.WriteLine("Tebak angka antara 1 dan 10:");

            while (tebakanPengguna != angkaTebakan)
            {
                Console.Write("Masukkan tebakan Anda: ");
                string input = Console.ReadLine();
                jumlahCoba++;

                if (int.TryParse(input, out tebakanPengguna))
                {
                    if (tebakanPengguna < angkaTebakan)
                    {
                        Console.WriteLine("Salah");
                    }
                    else if (tebakanPengguna > angkaTebakan)
                    {
                        Console.WriteLine("Salah broo");
                    }
                    else
                    {
                        Console.WriteLine($"Benar! Kamu sudah coba {jumlahCoba} kali");
                    }
                }
                else
                {
                    Console.WriteLine("Input tidak valid. Masukkan angka antara 1 dan 100.");


                }
            }
        }    }
}
