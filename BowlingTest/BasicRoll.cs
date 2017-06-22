namespace BowlingTest
{
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
}