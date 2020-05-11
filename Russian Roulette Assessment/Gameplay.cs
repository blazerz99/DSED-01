using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roulette_Assessment
{
    public class Gameplay
    {
        //public int LionRoom;
        public int Win = 0;
        public int Lose = 0;
        public int SavedPups = 0; // same as Score but i need  2 to reset every new level
        public int Score = 0;
        //public static int[] Puppies;
        public string LionChoiceText { get; set; }

        // Tells the where the puppies are(0 as in puppies)
        int[] Puppies = new int[6] { 0, 0, 0, 0, 0, 0 };

        Random myRandom = new Random();

        public string Play()
        {
            // Finds a random number/room the lion goes in to
            int LionRoom = myRandom.Next(0, 6);

            // Insert Lion into one of the Puppies room/array
            Puppies[LionRoom] = 1;


            bool gameOver = false;
            int RoomLion = 0;

            do
            {
                if (Puppies[RoomLion] == 1)
                {
                    gameOver = true;
                    Lose++;
                    return "You Are Dead ";
                }
                else
                {
                    Score++;
                    SavedPups++;
                    return "You saved a Puppy";
                }

            } while (gameOver == false);

        }

        public string Nextlvl()
        {
            // Finds a random number/room the lion goes in to
            int LionRoom = myRandom.Next(0, 6);

            // Insert Lion into one of the Puppies room/array
            Puppies[LionRoom] = 1;

            bool gameOver = false;

            int RoomLion = 0;

            do
            {
                if (Puppies[RoomLion] == 1)
                {
                    gameOver = true;
                    Lose++;
                    return "You Are Dead ";
                }
                else
                {
                    //Score++;
                    //SavedPups++;
                    return "You saved a Puppy";
                }

            } while (gameOver == false);

        }

        public string Skip()
        {

            Puppies.Skip(1); // skips one elment in the array Puppies
            return "Skipped Door";

        }

        public bool ConditionWin() //Condition to in the game
        {
            if (SavedPups >= 4)
            {
                Win++;
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

