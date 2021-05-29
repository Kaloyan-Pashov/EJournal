using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EJournal.Models
{
    //public enum Value
    //{
    //    _6_=6, _5_=5, _4_=4, _3_=3, _2_=2
    //}
   
    public class Grade
    {
        public int GradeID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }

        //[DisplayFormat(NullDisplayText = "No Grade")]
        //public Value? Value { get; set; }

        [StringLength(1)]
        [RegularExpression("^[2-6]+$")]
        public string Value { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime GradeDate { get; set; }

        public Student Student { get; set; }
        public Subject Subject { get; set; }

    }
}