using System.Collections.Generic;
using System.Linq;

namespace BowlingTest
{
    public class BasicRoll : IRule
    {
        public bool match(Frame frame)
        {
            return true;
        }

        public int compute(Frame frame, IEnumerable<Frame> followingFrames, int finalScore)
        {
            return finalScore + frame.Rolls.Sum();
        }
    }
}