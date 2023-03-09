namespace PZ7_2
{
    public class Airport : IObservable
    {
        private List<IObserver> clients;
        private List<string> bagages_id;

        public Airport()
        {
            clients = new List<IObserver>();
            bagages_id = new List<string>();
    }
        public void Subscribe(IObserver client)
        {
            clients.Add(client);
            Notify();
        }
        public void Unsubscribe(IObserver client)
        {
            clients.Remove(client);
            client.OnCompleted();
        }
        public void BagageArrive(Bagage bagage)
        {
            this.bagages_id.Add(bagage.Number);
            Notify();
        }
        public void Notify()
        {
            foreach (Client clinet in clients)
            {
                if (bagages_id.Contains(clinet.Number))
                {
                    clinet.OnNext();
                    clinet.OnCompleted();
                    bagages_id.Remove(clinet.Number);
                }
            }
        }

    }
}
