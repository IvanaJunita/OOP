using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    class OOP
    {
        public abstract class Process
        {
            public abstract double processing();
        }
        /*
        //rumus segitiga
        */
        public class segitiga : Process
        {
            public double sisi1;
            public double sisi2;
            public double sisi3;

            //constructor
            public segitiga(double a, double b, double c)
            {
                sisi1 = a;
                sisi2 = b;
                sisi3 = c;
            }
            //overide
            public override double processing()
            {
                return (sisi1 + sisi2 + sisi3);
            }
        }
        /*
        //lingkaran
        */
        public class lingkaran : Process
        {
            public double jari;
            //constructor
            public lingkaran(double a)
            {
                jari = a;
            }
            //overide
            public override double processing()
            {
                return (2 * (Convert.ToDouble(3.14)) * jari);
            }
        }
        /*
        //persegipanjang
        */
        public class persegipanjang : Process
        {
            public double panjang;
            public double lebar;

            //constructor
            public persegipanjang(double a, double b)
            {
                panjang = a;
                lebar = b;
            }
            //overide
            public override double processing()
            {
                return (2 * (panjang + lebar));
            }
        }
        /*
        //trapesium
        */
        public class trapesium : Process
        {
            public double sisiab;
            public double sisibc;
            public double sisicd;
            public double sisida;

            //constructor
            public trapesium(double a, double b, double c, double d)
            {
                sisiab = a;
                sisibc = b;
                sisicd = c;
                sisida = d;
            }
            //overide
            public override double processing()
            {
                return (sisiab + sisibc + sisicd + sisida);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Perhitungan Keliling");
            Console.WriteLine("=========================");
            Console.WriteLine("1. Segitiga");
            Console.WriteLine("2. Lingkaran");
            Console.WriteLine("3. Persegi Panjang");
            Console.WriteLine("4. Trapesium");
            Console.WriteLine("--------------------------");
            Console.Write("Tentukan Pilihanmu: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Keliling Segitiga");
                Console.Write("insert sisi 1:");
                Double sisi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("insert sisi 2: ");
                Double sisi2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("insert sisi 3:");
                Double sisi3 = Convert.ToDouble(Console.ReadLine());
                Process P1 = new segitiga(sisi1, sisi2, sisi3);
                Double e = P1.processing();
                Console.WriteLine("hasil :" + e);
            }
            else if (number == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Keliling lingkaran");
                Console.Write("insert jari-jari:");
                Double jari = Convert.ToDouble(Console.ReadLine());
                Process P2 = new lingkaran(jari);
                Double f = P2.processing();
                Console.WriteLine("hasil :" + f);
            }
            else if (number == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("Keliling persegi panjang");
                Console.Write("insert panjang:");
                Double panjang = Convert.ToDouble(Console.ReadLine());
                Console.Write("insert lebar: ");
                Double lebar = Convert.ToDouble(Console.ReadLine());
                Process P3 = new persegipanjang(panjang, lebar);
                Double g = P3.processing();
                Console.WriteLine("hasil :" + g);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Keliling trapesium");
                Console.Write("insert sisi ab:");
                Double sisiab = Convert.ToDouble(Console.ReadLine());
                Console.Write("insert sisi bc: ");
                Double sisibc = Convert.ToDouble(Console.ReadLine());
                Console.Write("insert sisi cd:");
                Double sisicd = Convert.ToDouble(Console.ReadLine());
                Console.Write("insert sisi da:");
                Double sisida = Convert.ToDouble(Console.ReadLine());
                Process P4 = new trapesium(sisiab, sisibc, sisicd, sisida);
                Double h = P4.processing();
                Console.WriteLine("hasil :" + h);
            }
            Console.Read();
        }
    }
}



