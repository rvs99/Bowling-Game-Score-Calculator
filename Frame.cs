using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game
{
    class Frame
    {
        public int FirstTry { get; set; }

        public int SecondTry { get; set; }

        public FrameType FrameResultType { get; set; }

        public bool IsFrameCompleted { get; set; }

        public Frame()
        {
            FirstTry = -1;
            SecondTry = -1;
            IsFrameCompleted = false;
            FrameResultType = FrameType.None;
        }

        public int Roll(int pinsDown, int score)
        {
            if (FirstTry == -1)
            {
                FirstTry = pinsDown;

                if (pinsDown == 10)
                {
                    FrameResultType = FrameType.Strike;
                    SecondTry = 0;
                    IsFrameCompleted = true;
                }
            }
            else if (SecondTry == -1)
            {
                SecondTry = pinsDown;

                if ((FirstTry + SecondTry) == 10)
                {
                    FrameResultType = FrameType.Spare;
                }

                IsFrameCompleted = true;
            }

            score += pinsDown;

            return score;
        }
    }

    enum FrameType
    {
        None,
        Strike,
        Spare
    }
}
