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
        public int AccountID { get; set; }
        //--------------------------------//
        [Display(Name = "Pickup Day")]
        public DayOfWeek PickUpDay { get; set; }
        //--------------------------------//
        [Display(Name = "One Time Pickup")]
        public DateTime OneTimePickUp { get; set; }
        //--------------------------------//
        [Display(Name = "Account Status")]
        public bool AccountStatus { get; set; }
        //--------------------------------//
        [Display(Name = "Start Day")]
        public DateTime StartDay { get; set; }
        //--------------------------------//
        [Display(Name = "End Day")]
        public DateTime EndDay { get; set; }
        //--------------------------------//
        [Display(Name = "Balance")]
        public double Balance { get; set; }
    }
}
