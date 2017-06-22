namespace BowlingTest
{
    public class SpareRoll : IRule
    {
        public bool match(Frame frame)
        {
            return true;
        }

        public int compute(int i, int finalScore)
        {
            return finalScore + 10 + i;
        }
    }
}