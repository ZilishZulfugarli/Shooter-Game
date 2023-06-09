using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    internal class P92 : Main, IZoom
    {
        public P92(int totalbullet, int currentbullet) : base(totalbullet, currentbullet)
        {
            TotalBulletCount = totalbullet;
            CurrentBulletCount = currentbullet;
            TotalBulletCount = Math.Max(0, 60);
        }
        public override int TotalBulletCount { get; protected set; }
        public override int CurrentBulletCount { get; protected set; }

        public override void Shot(int s)
        {

            CurrentBulletCount = CurrentBulletCount - s;
            if (CurrentBulletCount > 0)
            {
                Console.WriteLine("P92 Shooting..." + '\n' + "Bullet Count --" + " " + CurrentBulletCount);
            }
            if (CurrentBulletCount < 0)
            { throw new InvalidBulletCountException("Error"); }


        }



        public override void Reload()
        {
            CurrentBulletCount = TotalBulletCount;
            Console.WriteLine("P92 Reloading..." + '\n' + "Bullet Count --" + " " + TotalBulletCount);
        }
        
        

        public void Zoom(string a)
        {
            
            Console.WriteLine("P92 Zooming" + " - " + a);
        }
    }

}


