using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EJournal.Models
{
    public class User : IdentityUser
    {
        [Required]
        [PersonalData]
        public string FirstName { get; set; }
        [Required]
        [PersonalData]
        public string LastName { get; set; }
        [Required]
        [PersonalData]
        public string PersonalNo { get; set; }
    }
}
