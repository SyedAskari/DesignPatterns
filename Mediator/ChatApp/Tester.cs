namespace Mediator.ChatApp
{
    public class Tester : TeamMember
    {
        public Tester(string name) : base(name)
        {
        }

        public override void Recieve(string from, string message)
        {
            Console.WriteLine($"{this.Name} ({nameof(Tester)}) has recieved");
            base.Recieve(from, message);
        }
    }
}
