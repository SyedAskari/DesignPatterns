namespace Mediator.ChatApp
{
    /// <summary>
    /// Colleague
    /// </summary>
    public abstract class TeamMember
    {
        public TeamMember(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        private ChatRoom chatRoom;

        internal void SetChatroom(ChatRoom chatRoom)
        {
            this.chatRoom = chatRoom;
        }

        public void Send(string message)
        {
            this.chatRoom.SendMessageToAllTeamMembers(this.Name, message);
        }

        public void SendTo<T>(string message) where T : TeamMember
        {
            this.chatRoom.SendMessageToSpecificGroup<T>(this.Name, message);
        }

        public virtual void Recieve(string from, string message)
        {
            Console.WriteLine($"{from}: {message}");
        }
    }
}