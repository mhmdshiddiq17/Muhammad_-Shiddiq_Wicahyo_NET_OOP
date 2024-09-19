// See https://aka.ms/new-console-template for more information
using System;

namespace UserManagement
{ 
    class User
    {
        //atribut
        string nama = "Shiddiq";
        string role = "CTO";
        int emoney = 10000000;
        //Method
        public void UserDetail()
        {
            Console.WriteLine("ini detail usernya");
        }
        static void Main(string[] args)
        {
            User userBootcamp = new User();
            userBootcamp.UserDetail();
            Console.WriteLine("nama" + userBootcamp.nama);
            Console.WriteLine("Role" + userBootcamp.role);
            Console.WriteLine("E-Money" + userBootcamp.emoney);
        }

    }
}
