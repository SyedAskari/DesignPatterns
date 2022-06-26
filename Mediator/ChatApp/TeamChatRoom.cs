namespace Mediator.ChatApp
{
    /// <summary>
    /// Concrete Mediator
    /// </summary>
    public class TeamChatRoom : ChatRoom
    {
        private List<TeamMember> teamMembers = new List<TeamMember>();
        public override void RegisterTeamMember(TeamMember teamMember)
        {
            teamMember.SetChatroom(this);
            teamMembers.Add(teamMember);
        }

        public void RegisterMembers(params TeamMember[] teamMembers)
        {
            foreach (TeamMember teamMember in teamMembers)
            {
                this.RegisterTeamMember(teamMember);
            }
        }

        public override void SendMessageToAllTeamMembers(string from, string message)
        {
            teamMembers.ForEach(teamMember => teamMember.Recieve(from, message));
        }

        public override void SendMessageToSpecificGroup<T>(string from, string message)
        {
            teamMembers.OfType<T>().ToList().ForEach(teamMember => teamMember.Recieve(from, message));
        }
    }
}
