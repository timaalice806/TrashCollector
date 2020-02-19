using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
    public class Account
    {
        [Key]
        public int ID { get; set; }
        public string PickUpDay { get; set; }
        public DateTime OneTimePickUp { get; set; }
        public bool AccountStatus { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public double Balance { get; set; }
    }
}
