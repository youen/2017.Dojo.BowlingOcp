using System.Collections.Generic;
using System.Linq;

namespace BowlingTest
{
    public class SpareRule : IRule
    {
        public bool match(IEnumerable<Frame> frames)
        {
            var frame = frames.First();
            return AllPinsShoudBeDown(frame)  
                && WithAtLeastTwoRoll(frame) 
                && TheFollowingFrameShoudBeStarted(frames)
                && AtLeastOneRollOfTheFollowingFrameShoudBeDone(frames);
        }

        public int compute(IEnumerable<Frame> frames, int finalScore)
        {
            var nextScore = 0;
            var followingFrame = frames.Skip(1).First();
            nextScore = followingFrame.Rolls[0];
         
            return finalScore + frames.First().Rolls.Sum() + nextScore;
        }

        private bool AtLeastOneRollOfTheFollowingFrameShoudBeDone(IEnumerable<Frame> frames)
        {
            return frames.ElementAt(1).Rolls.Count > 0;
        }

        private static bool TheFollowingFrameShoudBeStarted(IEnumerable<Frame> frames)
        {
            return frames.Count() > 1;
        }

        private static bool WithAtLeastTwoRoll(Frame frame)
        {
            return frame.Rolls.Count > 1;
        }

        private static bool AllPinsShoudBeDown(Frame frame)
        {
            return frame.Rolls.Sum() == 10;
        }
    }
}