namespace PZ7_2
{
    public class Bagage
    {
        private static int n = 0;
        public string Number { get; private set; }
        public Bagage()
        {
            Number = n.ToString();
            n++;
        }
    }
}
