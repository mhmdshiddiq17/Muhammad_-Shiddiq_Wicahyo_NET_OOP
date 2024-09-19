using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
    // Kelas Customer sebagai turunan dari User
    public class Customer : User
    {

        public Customer(string nama, decimal eMoney) : base(nama, "Customer", eMoney) { }


        public void LihatSaldo()
        {

            Console.WriteLine($"Saldo {Nama}: {EMoney}");
        }
    }
}
