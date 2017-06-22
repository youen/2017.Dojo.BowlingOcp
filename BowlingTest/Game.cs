using System.Linq;

namespace BowlingTest
{
    public class Game
    {
        private int _finalScore = 0;
        private IRule[] _rules;

        public Game()
        {   
            _rules = new IRule[]
            {
                //new SpareRoll(),
                new BasicRoll()
            };
        }

        public void roll(int i)
        {
            var tmp = new Frame();
            tmp.roll(i);
            _finalScore = _rules.First(r => r.match(tmp)).compute(
                i, _finalScore);
        }

        public int score()
        {
            return _finalScore;
        }
    }
}