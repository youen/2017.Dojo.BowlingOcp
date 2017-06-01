using System;
using System.Linq;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void Roll_1_and_4_score_return_5()
        {
            var game = new Game();
            game.roll(1);
            game.roll(4);
            Assert.AreEqual(5, game.score());
        }

        [TestMethod]
        public void Roll_2_and_2_score_return_4()
        {
            var game = new Game();
            game.roll(2);
            game.roll(2);
            Assert.AreEqual(4, game.score());
        }

        /*[TestMethod]
        public void Roll_1_and_9_and_1_score_return_12()
        {
            var game = new Game();
            game.roll(1);
            game.roll(9);

            game.roll(1);
            game.roll(0);
            Assert.AreEqual(12, game.score());
        }*/

    }

    public class BasicRoll
    {

        public bool match(Frame frame)
        {
            return true;
        }

        public int compute(int i, int finalScore)
        {
            return finalScore + i;
        }
    }

    public class SpareRoll
    {

        public bool match(Frame frame)
        {
            return true;
        }

        public int compute(int i, int finalScore)
        {
            return finalScore + i;
        }
    }

    public class Frame
    {
        public void roll(int i)
        {
            
        }
    }

    public class Game
    {
        private int _finalScore = 0;
        private BasicRoll[] _rules;

        public Game()
        {
            _rules = new[] {new BasicRoll()};
        }

        public void roll(int i)
        {
            var tmp = new Frame();
            tmp.roll(i);
            _finalScore = _rules.First(r => r.match(tmp)).compute(i, _finalScore);
        }

        public int score()
        {
            return _finalScore;
        }
    }
}
