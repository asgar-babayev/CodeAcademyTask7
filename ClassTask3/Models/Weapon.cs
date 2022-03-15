using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask3.Models
{
    class Weapon
    {
        public int bulletCapacity;
        public int bulletCount;
        public double bulletShootSecond;
        public bool autoMode;


        public Weapon(int bulletCapacity, int bulletCount, double bulletShootSecond, bool autoMode)
        {
            this.bulletCapacity = bulletCapacity;
            this.bulletCount = bulletCount;
            this.bulletShootSecond = bulletShootSecond;
            this.autoMode = autoMode;
            if (bulletCapacity < bulletCount)
            {
                Console.WriteLine("Güllə sayısı güllə tutumundan çox ola bilməz");
            }
        }

        public void Shoot()
        {
            if (autoMode == true)
                Console.WriteLine("Auto modda tək güllə atıla bilməz");
            else if (bulletCount != 0)
            {
                Console.WriteLine("pew");
                Console.WriteLine($"Qalan güllə sayısı: {--bulletCount}");
            }
            else
                Console.WriteLine("Daraq boşdur");
        }

        public void Fire()
        {
            double shootedbulletSecond = 0;
            if (bulletCount != 0)
            {
                shootedbulletSecond = (bulletCount * bulletShootSecond) / bulletCapacity;
                bulletCount = 0;
                Console.WriteLine($"Güllə {Math.Round(shootedbulletSecond, 2)} saniyəyə bitdi");
                if (autoMode == true)
                    Console.WriteLine("pew pew");
                else
                    Console.WriteLine("pew");
            }
            else
                Console.WriteLine("Daraq boşdur");
        }

        public void GetRemainBulletCount()
        {
            if (bulletCount != 0 && bulletCapacity != 0 && bulletCapacity < bulletCount)
            {
                if (bulletCapacity - bulletCount == 0)
                    Console.WriteLine("Daraq doludur.");
                else
                    Console.WriteLine($"Darağın dolması ücün lazım olan güllə sayı = {bulletCapacity - bulletCount}");
            }
            else
                Console.WriteLine("Bu işdə bir tərslik var");
        }

        public void Reload()
        {
            if (bulletCapacity != 0 && bulletCapacity > bulletCount)
            {
                if (bulletCapacity - bulletCount == 0)
                    Console.WriteLine("Daraq doludur");
                else if(bulletCount == 0)
                {
                    Console.WriteLine($"Daraq maksimum dolduruldu. Güllə sayı: {bulletCapacity - bulletCount}");
                    bulletCount = bulletCapacity;
                }
            }
            else
                Console.WriteLine("Bu işdə bir tərslik var");
        }
        public void ChangeFireMode()
        {
            if (autoMode == false)
            {
                Console.WriteLine("Avtomatik mod aktivdir");
                autoMode = true;
            }
            else
            {
                Console.WriteLine("Avtomatik mod passivdir");
                autoMode = false;
            }
        }
        public void Info()
        {
            Console.WriteLine(@$"Maksimum tutum: {bulletCapacity}
Hazırki güllə sayısı: {bulletCount}
Güllənin boşalma saniyəsi :{bulletShootSecond}
Güllənin atış modu: {autoMode}
");
        }

    }

}
