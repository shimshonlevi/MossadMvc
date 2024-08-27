using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Mosad1View.Enums;

namespace Mosad1View.Models
{
    public class Mission
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Agent")]
        public int AgentID { get; set; }
        [ForeignKey("Target")]
        public int TargetID { get; set; }

        public TimeOnly ExecutionTime { get; set; }
        public double? TimeLeft { get; set; }
        public StatusMission? Status { get; set; } = StatusMission.Proposal;
    }
}

