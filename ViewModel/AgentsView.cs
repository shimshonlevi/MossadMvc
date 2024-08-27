using Mosad1View.Enums;
using Mosad1View.Models;

namespace Mosad1View.ViewModel
{
    public class AgentsView
    {
        public List<Agent> Agents { get; set; }
        public List<Location> Locations { get; set; }
        public string statuss { get; set; }
        public string mission { get; set; }
        public DateTime timeLept { get; set; }

        public int countKils { get; set; }

        //public AgentsView(List<Agent> agents, List<Target> targets, List<Mission> missions)
        //{
        //    Agents = agents;
        //    Locations = agents.Location;


        //    statuss = agents.status?.Count ?? 0;
        //    EliminatTargets = targets?.Count(t => t.status == StatusTarget.Eliminated) ?? 0;


        //    TotalMissions = missions?.Count ?? 0;
        //    ActiveMissions = missions?.Count(m => m.Status == StatusMission.InProgress) ?? 0;


        //    AgentToTarget = Calculate(ActiveAgents ?? 0, TotalTargets ?? 0);
        //    CenAgentToTarget = Calculate(agents?.Count(a => CanAssignAgent(a)) ?? 0, targets?.Count(t => t.status == StatusTarget.Live) ?? 0);
        //}
    }

   
}
