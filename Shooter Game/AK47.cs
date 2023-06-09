using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    internal class AK47 : Main
    {
        public AK47(int totalbullet, int currentbullet) : base(totalbullet, currentbullet)
        {
            TotalBulletCount = totalbullet;
            CurrentBulletCount = currentbullet;
            TotalBulletCount = Math.Max(0, 32);
        }
        public override int TotalBulletCount { get; protected set; }
        public override int CurrentBulletCount { get; protected set; }

        public override void Shot(int s)
        {

            CurrentBulletCount = CurrentBulletCount - s;
            if (CurrentBulletCount > 0)
            {
                Console.WriteLine("AK47 Shooting..." + '\n' + "Bullet Count --" + " " + CurrentBulletCount);
            }
            if (CurrentBulletCount < 0)
            { throw new InvalidBulletCountException("Error"); }


        }



        public override void Reload()
        {
            CurrentBulletCount = TotalBulletCount;
            Console.WriteLine("AK47" +
                "" +
                " Reloading..." + '\n' + "Bullet Count --" + " " + TotalBulletCount);
        }
    }
}
