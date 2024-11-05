namespace Tut5_s20123.Observer
{
    public class ConcreteObserver(string userName) : IObserver
    {
        public string UserName { get; set; } = userName;

        public void Update(string availability)
        {
            Console.WriteLine($"Hello {UserName}, Product is now {availability} on Amazon");
        }

        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
            Console.WriteLine($"{UserName} has subscribed to notifications.");
        }

        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
            Console.WriteLine($"{UserName} has unsubscribed from notifications.");
        }
    }
}