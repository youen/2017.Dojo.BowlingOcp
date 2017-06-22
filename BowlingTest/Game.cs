using System.Collections.Generic;
using System.Linq;

namespace BowlingTest
{
    public class Game
    {
        private int _finalScore = 0;

        public void roll(int i)
        {
            _frames.Last().roll(i);
            if (_frames.Last().Rolls.Count == 2)
            {
                _frames.Add(new Frame());
            }

            var score = 0;
            foreach (var frame in _frames)
            {
                score = _rules.First(r => r.match(frame)).compute(
                    frame, FollowingFrames(frame), score);
            }
            _finalScore = score;
        }

        private IEnumerable<Frame> FollowingFrames(Frame frame)
        {
            var list = new List<Frame>();
            var add = false;
            foreach (var frameToAdd in _frames)
            {
                if (add)
                {
                    list.Add(frameToAdd);    
                }

                if(frameToAdd == frame)
                {
                    add = true;
                }
                
            }

            return list;
        }

        private IRule[] _rules;

        private List<Frame> _frames;

        public Game()
        {   
            _rules = new IRule[]
            {
                new BasicRoll()
            };
            _frames = new List<Frame>()
            {
                new Frame()
            };

        }

        public int score()
        {
            return _finalScore;
        }
    }
}