using Mosad1View.Enums;
using Mosad1View.Models;

namespace Mosad1View.ViewModel
{
    public class MainView
    {
       //כל הסוכנים
        public int? TotalAgents { get; set; }

       //כל הסוכנים הפעילים
        public int? ActiveAgents { get; set; }

     //כל המטרות
        public int? TotalTargets { get; set; }

       //מטרות שחוסלו
        public int? EliminatTargets { get; set; }

      //כל המשימות
        public int? TotalMissions { get; set; }

     //משימות בפעילות
        public int? ActiveMissions { get; set; }

        //יחס סוכנים למטרות
        public double? AgentToTarget { get; set; }

        //יחס סוכנים שאפשר לצוות למטרות מול מטרות
        public double? CenAgentToTarget { get; set; }

       
        public MainView(List<Agent> agents, List<Target> targets, List<Mission> missions)
        {
            TotalAgents = agents?.Count ?? 0;
            ActiveAgents = agents?.Count(a => a.Status == StatusAgent.InActive)?? 0;


            TotalTargets = targets?.Count ??0;
            EliminatTargets = targets?.Count(t => t.status == StatusTarget.Eliminated) ?? 0;


            TotalMissions = missions?.Count?? 0;
            ActiveMissions = missions?.Count(m => m.Status == StatusMission.InProgress) ?? 0;

         
            AgentToTarget = Calculate( ActiveAgents??0,TotalTargets??0);
            CenAgentToTarget = Calculate(agents?.Count(a => CanAssignAgent(a))?? 0, targets?.Count(t => t.status == StatusTarget.Live)?? 0);
        }

       
        private double Calculate(int number1, int number2)
        {
            return number2 == 0 ? 0 : (double)number1 / number2;
        }

       
        private bool CanAssignAgent(Agent agent)
        {
          
            return agent.Status == StatusAgent.Dormant;
        }
    }
}

