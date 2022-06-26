namespace Mediator.ChatApp
{
    /// <summary>
    /// Mediator
    /// </summary>
    public abstract class ChatRoom
    {
        public abstract void RegisterTeamMember(TeamMember teamMember);
        public abstract void SendMessageToAllTeamMembers(string from, string message);
        public abstract void SendMessageToSpecificGroup<T>(string from, string message) where T: TeamMember;
    }
}
