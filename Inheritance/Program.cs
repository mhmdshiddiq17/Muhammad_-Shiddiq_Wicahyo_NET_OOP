using System;

namespace Inheritance
{ 
    //parent class
    public class Lingkaran
    {
        double luas;

        //method untuk menghitung luas
        public int LuasLingkaran(double r)
        {
            luas = 3.14 * r * r;
            return (int)luas;
        }
    }

    //child class
    public class Tabung : Lingkaran
    {
        double volume;
        public Tabung(int tinggi, double r)
        {
            volume = tinggi * this.LuasLingkaran(r);
        }

        public double getVolume()
        {
            return volume;
        }
        static void Main(string[] args)
        {
            //membuat objek
            Tabung hasilTabung = new Tabung(10, 2);

            //menampilkan volume tabung
            Console.WriteLine("hasil dari tabung adalah : " + hasilTabung.getVolume());
        }

    }

}



