using ClassTask3.Models;
using System;

namespace ClassTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding("UTF-16");


            Console.Write("Darağın maksimum tutumunu daxil edin: ");
            int bulletCapacity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hazırda olan güllə sayını daxil edin: ");
            int bulletCount = Convert.ToInt32(Console.ReadLine()); ;
            Console.Write("Darağın boşalma saniyəsini daxil edin: ");
            double bulletShootSecond = Convert.ToDouble(Console.ReadLine()); ;
            Console.Write("Avtomatik modun aktiv və ya passiv olmasını daxil edin(True ya da False): ");
            bool autoMode = Convert.ToBoolean(Console.ReadLine()); ;
            Weapon w = new Weapon(bulletCapacity, bulletCount, bulletShootSecond, autoMode);

            int key = 0;
            while (key != 6)
            {

                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 0:
                        Console.WriteLine("Ümümi Məlumat");
                        Console.WriteLine(@$"0-Info:
1-Shoot
2-Fire
3-GetRemainBulletCount
4-Reload
5-ChangeFireMode
6-Sagolun
");
                        break;
                    case 1:
                        Console.WriteLine("Shoot metodu cagirildi");
                        w.Shoot();
                        break;
                    case 2:
                        Console.WriteLine("Fire metodu cagirildi");
                        w.Fire();
                        break;
                    case 3:
                        Console.WriteLine("GetRemainBulletCount metodu cagirildi");
                        w.GetRemainBulletCount();
                        break;
                    case 4:
                        Console.WriteLine("Reload metodu cagirildi");
                        w.Reload();
                        break;
                    case 5:
                        Console.WriteLine("ChangeFireMode metodu cagirildi");
                        w.ChangeFireMode();
                        break;
                    case 6:
                        Console.WriteLine("Sagolun.");
                        break;
                    default:
                        Console.WriteLine("0-6 araliginda reqem daxil edib metodlari cagira bilersiz");
                        break;
                }
            }
        }
    }
}
