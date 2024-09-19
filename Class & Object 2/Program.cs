using System;

namespace UserBootcamp
{

    class User
    {
        static void Main(string[] args)
        {
            UserBootcamp11 _userBootcamp11 = new UserBootcamp11();
            _userBootcamp11.NamaUser = "Shiddiq";
            _userBootcamp11.RoleUser = "admin";

            Console.WriteLine("Nama : " + _userBootcamp11.NamaUser);
            Console.WriteLine("Role : " + _userBootcamp11.RoleUser);
        }
    }



    public class UserBootcamp11
    {
        string nama;
        string role;
        int emoney;

        public string NamaUser
        {
            get { return nama; }
            set { nama = value; }
        }

        public string RoleUser
        {
            get { return role; }
            set { role = value; }
        }

        public int Emoney
        {
            get { return emoney; }
            set {emoney = value;}
        }
        
    }
}
