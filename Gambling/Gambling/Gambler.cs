using System;
using System.Collections.Generic;
using System.Text;

namespace Gambling
{
    class Gambler
    {
        int Bet= 1;
        int Amount= 100;
        const int WIN = 0;
        const int LOOSE = 1;
        public void playGame()
        {
            Random random = new Random();
            int game = random.Next(0, 2);
            Console.WriteLine("amount is=" + Amount);
            Console.WriteLine("Bet is "+Bet);
            if (game == WIN) 
            {
                Console.WriteLine("Player Win");
            }

            if (game==LOOSE)
            {
                Console.WriteLine("Player Loose");
            }
        }
        
        
        
        
        
           

        

        
    }
}
