using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EJournal.Models
{
    public class Subject
    {
        public int ID { get; set; }

        [Required]
        public string SubjectName { get; set; }



    }
}
