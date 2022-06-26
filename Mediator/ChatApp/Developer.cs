namespace Mediator.ChatApp
{
    public class Developer : TeamMember
    {
        public Developer(string name) : base(name)
        {
        }

        public override void Recieve(string from, string message)
        {
            Console.WriteLine($"{this.Name} ({nameof(Developer)}) has recieved");
            base.Recieve(from, message);
        }
    }
}
