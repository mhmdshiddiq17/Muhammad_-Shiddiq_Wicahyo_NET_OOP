using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
    public class Admin : User
    { 
        public Admin(string nama) : base(nama, "Admin", 0) { }


        public void TambahSaldo(Customer customer, decimal jumlah)
        {
            // Tambah saldo customer
            customer.EMoney += jumlah;
            Console.WriteLine($"Saldo customer {customer.Nama} berhasil ditambah sebesar {jumlah}.");
            Console.WriteLine($"Saldo saat ini: {customer.EMoney}");
        }
    }
}
