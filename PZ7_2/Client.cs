namespace PZ7_2
{
    public class Client : IObserver
    {
        static int n = 0;
        public string Name { get; private set; }
        public string Number { get; private set; }

        public Client(string name)
        {
            Name = name;
            Number = n.ToString();
            n++;
        }
        public void OnCompleted()
        {
            Console.WriteLine("Багаж получен!");
        }
        public void OnNext()
        {
            Console.WriteLine("Багаж прибыл!");
        }
    }
}
