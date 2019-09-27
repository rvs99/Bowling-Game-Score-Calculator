using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game
{
    class Game
    {
        //input
        //int[] rolls = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };  // score 300

        //int[] rolls = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };  // score 20

        //int[] rolls = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };  // score 40

        //int[] rolls = { 2, 3, 2, 3, 2, 3, 2, 3, 2, 3, 2, 3, 2, 3, 2, 3, 2, 3, 2, 3 };  // score 50

        //int[] rolls = { 10, 9, 1, 5, 5, 7, 2, 10, 10, 10, 9, 0, 8, 2, 9, 1, 10 };  // score 187

        //int[] rolls = { 10, 7, 3, 9, 0, 10, 0, 8, 8, 2, 0, 6, 10, 10, 10, 8, 1 };  // score 167

        //int[] rolls = { 5, 3, 4, 5, 3, 5, 10, 6, 3, 8, 1, 3, 6, 4, 6, 5, 3, 2, 2 };

        int[] rolls = { 4, 3, 5, 4, 5, 5, 9, 1, 9, 0, 10, 5, 3, 6, 4, 8, 1, 8, 1 };  // score 125

        Frame[] frames;

        public int Score { get; set; }

        public Game()
        {
            frames = new Frame[10];
            Score = 0;
        }

        public void StartGame()
        {
            int frameCounter = 0;

            for (int i = 0; i < rolls.Length && frameCounter < 10; i++)
            {
                if (frames[frameCounter] == null)
                    frames[frameCounter] = new Frame();

                Score = frames[frameCounter].Roll(rolls[i], Score);

                if (frames[frameCounter].IsFrameCompleted)
                {
                    if (frames[frameCounter].FrameResultType == FrameType.Strike)
                        Score += rolls[i + 1] + rolls[i + 2];

                    else if (frames[frameCounter].FrameResultType == FrameType.Spare)
                        Score += rolls[i + 1];

                    frameCounter++;
                }       
            }
        }

        public void PrintScore()
        {
            Console.Out.WriteLine("Score : " + Score);
        }
    }
}
