using System;
using System.Collections.Generic;

namespace Tugas
{
    // Kelas utama Program
    class Program
    {
        
        static List<Customer> daftarCustomer = new List<Customer>();

        // Fungsi utama program
        static void Main(string[] args)
        {
            
            daftarCustomer.Add(new Customer("Ahmad", 100000));
            daftarCustomer.Add(new Customer("Budi", 150000));
            daftarCustomer.Add(new Customer("Chandra", 200000));

            // Cetak pesan selamat datang dan minta input role dari pengguna
            Console.WriteLine("Selamat datang di sistem E-Money!");
            Console.Write("Masukkan role anda (Admin/Customer): ");
            string role = Console.ReadLine();

            
            if (role.ToLower() == "admin")
            {
                
                Console.Write("Masukkan nama Admin: ");
                string namaAdmin = Console.ReadLine();

                
                Admin admin = new Admin(namaAdmin);
                Console.WriteLine($"Halo, {admin.Nama}! Anda login sebagai Admin.");

                
                Console.Write("Masukkan nama Customer yang akan diberi saldo: ");
                string namaCustomer = Console.ReadLine();

                
                Customer customer = CariCustomer(namaCustomer);

                // Jika customer ditemukan
                if (customer != null)
                {
                    // Minta jumlah saldo yang ingin ditambahkan
                    Console.Write("Masukkan jumlah saldo yang akan ditambahkan: ");
                    decimal jumlahTambahSaldo = Convert.ToDecimal(Console.ReadLine());

                    // Tambahkan saldo customer
                    admin.TambahSaldo(customer, jumlahTambahSaldo);
                }
                else
                {
                    // Jika customer tidak ditemukan
                    Console.WriteLine("Customer tidak tersedia.");
                }
            }
            
            else if (role.ToLower() == "customer")
            {
                
                Console.Write("Masukkan nama Customer: ");
                string namaCustomer = Console.ReadLine();

                
                Customer customer = CariCustomer(namaCustomer);

                
                if (customer != null)
                {
                    Console.WriteLine($"Halo, {customer.Nama}! Anda login sebagai Customer.");
                    
                    customer.LihatSaldo();
                }
                else
                {
                    
                    Console.WriteLine("Customer tidak tersedia.");
                }
            }
            else
            {
                
                Console.WriteLine("Role tidak valid. Silakan coba lagi.");
            }
        }

        // Fungsi untuk mencari customer berdasarkan nama
        static Customer CariCustomer(string nama)
        {
            // Telusuri daftar customer untuk mencari customer dengan nama yang sesuai
            foreach (Customer customer in daftarCustomer)
            {
                // Jika nama customer ditemukan
                if (customer.Nama.ToLower() == nama.ToLower())
                {
                    return customer; // Kembalikan objek customer
                }
            }
            return null; // Jika tidak ditemukan, kembalikan null
        }
    }
}
