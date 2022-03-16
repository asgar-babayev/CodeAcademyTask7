using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask3.Models
{
    class Weapon
    {
        private int _bulletCapacity;
        private int _bulletCount;
        private double _bulletShootSecond;
        private bool _autoMode;

        public int BulletCapacity
        {
            get
            {
                if (_bulletCapacity > 0)
                    return _bulletCapacity;
                return -1;
            }
            set { _bulletCapacity = value; }
        }
        public int BulletCount
        {
            get
            {
                if (_bulletCount > 0)
                    return _bulletCount;
                return -1;
            }
            set { _bulletCount = value; }
        }
        public double BulletShootSecond
        {
            get
            {
                if (_bulletShootSecond > 0)
                    return _bulletShootSecond;
                return -1;
            }
            set { _bulletShootSecond = value; }

        }
        public bool AutoMode
        {
            get { return _autoMode; }
            set { _autoMode = value; }
        }

        public Weapon(int bulletCapacity, int bulletCount, double bulletShootSecond, bool autoMode)
        {
            BulletCapacity = bulletCapacity;
            BulletCount = bulletCount;
            BulletShootSecond = bulletShootSecond;
            AutoMode = autoMode;
            if (bulletCapacity < bulletCount)
                Console.WriteLine("Güllə sayısı güllə tutumundan çox ola bilməz");
        }

        public void Shoot()
        {
            if (_bulletCount != 0)
            {
                Console.WriteLine("pew");
                Console.WriteLine($"Qalan güllə sayısı: {--_bulletCount}");
            }
            else
                Console.WriteLine("Daraq boşdur");
        }

        public void Fire()
        {
            double shootedbulletSecond = 0;
            if (_bulletCount != 0)
            {
                shootedbulletSecond = (_bulletCount * _bulletShootSecond) / _bulletCapacity;
                _bulletCount = 0;
                Console.WriteLine($"Güllə {Math.Round(shootedbulletSecond, 2)} saniyəyə bitdi");
                if (_autoMode == true)
                    Console.WriteLine("pew pew");
                else
                    Console.WriteLine("pew");
            }
            else
                Console.WriteLine("Daraq boşdur");
        }

        public void GetRemainBulletCount()
        {
            if (_bulletCapacity != 0 && _bulletCapacity > _bulletCount)
            {
                if (_bulletCapacity - _bulletCount == 0)
                    Console.WriteLine("Daraq doludur.");
                else
                    Console.WriteLine($"Darağın dolması ücün lazım olan güllə sayı = {_bulletCapacity - _bulletCount}");
            }
            else
                Console.WriteLine("Bu işdə bir tərslik var");
        }

        public void Reload()
        {
            if (_bulletCapacity != 0 && _bulletCapacity > _bulletCount)
            {
                if (_bulletCapacity - _bulletCount == 0)
                    Console.WriteLine("Daraq doludur");
                else
                {
                    int bullet = _bulletCapacity - _bulletCount;
                    _bulletCount = _bulletCount + bullet;
                    Console.WriteLine($"Daraq maksimum dolduruldu. Güllə sayı: {_bulletCount}");
                }
            }
            else
                Console.WriteLine("Bu işdə bir tərslik var");
        }
        public void ChangeFireMode()
        {
            if (_autoMode == false)
            {
                Console.WriteLine("Avtomatik mod aktivdir");
                _autoMode = true;
            }
            else
            {
                Console.WriteLine("Avtomatik mod passivdir");
                _autoMode = false;
            }
        }
    }

}
