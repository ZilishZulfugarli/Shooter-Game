namespace Shooter_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Main m4 = new M4(0, 30);
            Main ak47 = new AK47(0, 32);
            Main p92 = new P92(0 , 60);
            Main awp = new AWP(0 , 10);
            
            try
            {
                
                m4.Shot(21);
                m4.Reload();

                Console.WriteLine('\n');

                ak47.Shot(19);
                ak47.Reload();

                Console.WriteLine('\n');

                
                ((IZoom)p92).Zoom("2x");
                p92.Shot(36);
                p92.Reload();

                Console.WriteLine('\n');

                ((IZoom)awp).Zoom("6x");
                awp.Shot(8);
                awp.Reload();



            }
            catch (InvalidBulletCountException e)
            {
              
                    Console.WriteLine("Error" + e.Message);
                
            }


        }
    }
}