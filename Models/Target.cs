using Mosad1View.Enums;
using System.ComponentModel.DataAnnotations;

namespace Mosad1View.Models
{
   
        public class Target
        {
            [Key]
            public int ID { get; set; }
            public string Name { get; set; }
            public Location? Location { get; set; }
            public StatusTarget? status { get; set; } = StatusTarget.Live;
        }
    }

