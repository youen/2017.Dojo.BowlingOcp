using System.Collections.Generic;
using System.Linq;

namespace BowlingTest
{
    public class BasicRoll : IRule
    {
        public bool match(IEnumerable<Frame> frame)
        {
            return true;
        }

        public int compute(IEnumerable<Frame> frames, int finalScore)
        {
            return finalScore + frames.First().Rolls.Sum();
        }
    }
}