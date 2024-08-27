using Mosad1View.Enums;

namespace Mosad1View.Models
{
    public class Agent
    {
        public int ID { get; set; }
        public string ImageUrl { get; set; }
        public string Alias { get; set; }

        public Location? Location { get; set; }
        public StatusAgent? Status { get; set; } = StatusAgent.Dormant;
    }
}
