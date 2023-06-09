using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    internal abstract class Main
    {

        public Main (int totalbullet, int currentbullet) 
        {
            if (currentbullet < 0)
            {
                throw new InsufficientBulletCountException("Error");
            }

            if (totalbullet < 0)
            {
                throw new InvalidBulletCountException ("Error");
            }
         TotalBulletCount = totalbullet;
            CurrentBulletCount = currentbullet;
        }  
        public abstract int TotalBulletCount { get; protected set; }

        
        
        public abstract  int CurrentBulletCount { get; protected set; }


        public abstract void Shot(int s);

        public abstract void Reload();

        
        
    }
    

}
