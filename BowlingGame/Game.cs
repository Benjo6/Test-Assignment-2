using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public sealed class Game
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;
        public void roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (isStrike(frameIndex))
                {
                    score += 10 + StrikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (isSpare(frameIndex))
                {
                    score += 10 + SpareBonus(frame);
                    frameIndex += 2;
                }
                else
                {
                    score += SumOfBallsInFrame(frameIndex);
                    frameIndex += 2;
                }
            }
            return score;
        }

        public bool isStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }
        public bool isSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }
        public int StrikeBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }
        public int SpareBonus(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }
        public int SumOfBallsInFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }
    }
}
