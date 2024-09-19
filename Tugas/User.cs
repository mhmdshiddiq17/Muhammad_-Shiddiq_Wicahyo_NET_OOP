using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
    // Kelas User yang menyimpan informasi umum pengguna
    public class User
    {

        public string Nama;
        public string Role;
        public decimal EMoney;


        public User(string nama, string role, decimal eMoney)
        {
            Nama = nama;
            Role = role;
            EMoney = eMoney;
        }
    }
}
