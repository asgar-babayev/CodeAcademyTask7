using ClassTask3.Models;
using System;

namespace ClassTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            int bulletCapacity = -1;
            int bulletCount = -1;
            int chooseMode = -1;
            double bulletShootSecond = -1;
            bool autoMode = true;

            CheckInput(ref bulletCapacity, ref bulletCount, ref bulletShootSecond, ref chooseMode, ref autoMode);
            Weapon w = new Weapon(bulletCapacity, bulletCount, bulletShootSecond, autoMode);

            int key = 0;
            while (key != 6)
            {
                Console.WriteLine("Ümümi məlumat almaq üçün 0 daxil edə bilərsiniz");
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
7-Redaktə et
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
                        Console.WriteLine("Sagolun");
                        break;
                    case 7:
                        Console.WriteLine($@"T-Güllə tutumunu dəyişmək üçündür
S-Hazırki güllə sayını dəyişmək üçündür
D-Darağın boşalma saniyəsini dəyişmək üçündür"); ;
                        string letter = Console.ReadLine();
                        switch (letter.ToUpper())
                        {
                            case "T":
                                do
                                {
                                    Console.Write("Darağın maksimum tutumunu daxil edin: ");
                                    w.BulletCapacity = Convert.ToInt16(Console.ReadLine());

                                    if (w.BulletCapacity <= 0 || w.BulletCapacity < w.BulletCount)
                                        Console.WriteLine("Yanlış məlumat daxil edildi");
                                }
                                while (w.BulletCapacity <= 0 || w.BulletCapacity < w.BulletCount);
                                break;
                            case "S":
                                do
                                {
                                     Console.Write("Hazırda olan güllə sayını daxil edin: ");
                                     w.BulletCount = Convert.ToInt16(Console.ReadLine());
                                     if (w.BulletCount < 0 || w.BulletCount > w.BulletCapacity)
                                        Console.WriteLine("Yanlış məlumat daxil edildi");
                                }
                                while (w.BulletCount < 0 || w.BulletCount >w.BulletCapacity);
                                break;
                            case "D":
                                do
                                {
                                    Console.Write("Darağın boşalma saniyəsini daxil edin: ");
                                    w.BulletShootSecond = Convert.ToDouble(Console.ReadLine());
                                    if (w.BulletShootSecond <= 0)
                                        Console.WriteLine("Yanlış məlumat daxil edildi");
                                } while (w.BulletShootSecond <= 0);
                                break;
                            default:
                                Console.WriteLine("Yanlış məlumat daxil edildi");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("0-6 araliginda reqem daxil edib metodlari cagira bilersiz");
                        break;
                }
            }
        }
        static void CheckInput(ref int bulletCapacity, ref int bulletCount, ref double bulletShootSecond, ref int chooseMode, ref bool autoMode)
        {
            while (bulletCapacity <= 0)
            {
                Console.Write("Darağın maksimum tutumunu daxil edin: ");
                bulletCapacity = Convert.ToInt16(Console.ReadLine());
                if (bulletCapacity <= 0)
                    Console.WriteLine("Yanlış məlumat daxil edildi");
            }
            while (bulletCount < 0 || bulletCount > bulletCapacity)
            {
                Console.Write("Hazırda olan güllə sayını daxil edin: ");
                bulletCount = Convert.ToInt16(Console.ReadLine());
                if (bulletCount < 0 || bulletCount > bulletCapacity)
                    Console.WriteLine("Yanlış məlumat daxil edildi");
            }
            while (bulletShootSecond <= 0)
            {
                Console.Write("Darağın boşalma saniyəsini daxil edin: ");
                bulletShootSecond = Convert.ToDouble(Console.ReadLine());
                if (bulletShootSecond <= 0)
                    Console.WriteLine("Yanlış məlumat daxil edildi");
            }
            while (true)
            {
                Console.Write("Avtomatik modun aktiv və ya passiv olmasını daxil edin(1 ya da 0): ");
                chooseMode = Convert.ToInt32(Console.ReadLine());
                if (chooseMode == 1)
                {
                    autoMode = true;
                    break;
                }
                else if (chooseMode == 0)
                {
                    autoMode = false;
                }
                else
                    Console.WriteLine("Yanlış məlumat daxil edildi");
            }
        }
    }
}
