using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace skarje
{
    class Game
    {
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public int Player1State { get; set; }
        public int Player2State { get; set; }

        public static int Player1HighScore { get; set; }
        public static int Player2HighScore { get; set; }

        public int rezultat;

        public Game()
        {
            Player1Score = 0;
            Player2Score = 0;
        }

        public int Play()
        {
            Player1State = HelperClass.GetState();
            Player2State = HelperClass.GetState();

            if (Player1State == Player2State)
            {
                rezultat = 0;
            }

            switch (Player1State)
            {
                case 1:
                    if (Player2State == 0)
                    {
                        rezultat = 2;
                    }
                    else if (Player2State == 2)
                    {
                        rezultat = 1;
                    }
                    break;
                case 2:
                    if (Player2State == 0)
                    {
                        rezultat = 1;
                    }
                    else if (Player2State == 1)
                    {
                        rezultat = 2;
                    }
                    break;
                case 0:
                    if (Player2State == 1)
                    {
                        rezultat = 1;
                    }
                    else if (Player2State == 2)
                    {
                        rezultat = 2;
                    }
                    break;
            }

            return rezultat;
        }
    }
}
