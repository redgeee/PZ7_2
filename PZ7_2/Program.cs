namespace PZ7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("C1");
            Bagage bagage = new Bagage();
            Airport airport = new Airport();
            airport.BagageArrive(bagage);
            airport.Subscribe(client);
        }
    }
}