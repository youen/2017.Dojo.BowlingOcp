using System;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace BowlingTest
{
    [TestClass]
    public class GameTest
    {
        [Theory]
        [InlineData("2,2", 4)]
        [InlineData("1,4", 5)]
        [InlineData("1,4,1,4,1,4,1,4,0,0,1,4,1,4,1,4,1,4,0,6", 46)]
        public void shouldconvert(string rolls, int score)
        {
            var game = new Game();

            foreach (var roll in rolls.Split(','))
            {
                game.roll(int.Parse(roll));
            }
            Assert.AreEqual(score, game.score());
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
}
