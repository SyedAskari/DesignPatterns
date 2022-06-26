namespace Mediator.ChatApp
{
    public class TeamChatRoom : ChatRoom
    {
        private List<TeamMember> teamMembers = new List<TeamMember>();
        public override void Register(TeamMember teamMember)
        {
            teamMember.SetChatroom(this);
            teamMembers.Add(teamMember);
        }

        public void RegisterMembers(params TeamMember[] teamMembers)
        {
            foreach (TeamMember teamMember in teamMembers)
            {
                this.Register(teamMember);
            }
        }

        public override void Send(string from, string message)
        {
            teamMembers.ForEach(teamMember => teamMember.Recieve(from, message));
        }

        public override void SendTo<T>(string from, string message)
        {
            teamMembers.OfType<T>().ToList().ForEach(teamMember => teamMember.Recieve(from, message));
        }
    }
}
