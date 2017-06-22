using System.Collections.Generic;
using System.Linq;

namespace BowlingTest
{
    public class SpareRoll : IRule
    {
        public bool match(Frame frame)
        {
            return frame.Rolls.Count != 1 && frame.Rolls.Sum() == 10;
        }

        public int compute(Frame currentFrame, IEnumerable<Frame> followingFrames, int finalScore)
        {
            var nextScore = 0;
            if (followingFrames.First().Rolls.Count > 0)
            {
                nextScore = followingFrames.First().Rolls[0];
            }

            return finalScore + currentFrame.Rolls.Sum() + nextScore;
        }
    }
}