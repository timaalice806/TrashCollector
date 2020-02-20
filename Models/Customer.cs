using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [ForeignKey("AddressID")]
        [Display(Name = "Address")]
        public int AddressID { get; set; }
        public Address Address { get; set; }
        [NotMapped]
        public IEnumerable<Address> Addresses { get; set; }

        [ForeignKey("AccountID")]
        [Display(Name = "Account")]
        public int AccountID { get; set; }
        public Account Account { get; set; }
        [NotMapped]
        public IEnumerable<Account> Accounts { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
