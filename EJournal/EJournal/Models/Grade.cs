﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EJournal.Models
{
    public enum Value
    {
        Otlichen=6, MnDobur=5, Dobur=4, Sreden=3, Slab2=2
    }
   
    public class Grade
    {
        public int GradeID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }

        [DisplayFormat(NullDisplayText = "No Grade")]
        public Value? Value { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime GradeDate { get; set; }

        public Student Student { get; set; }
        public Subject Subject { get; set; }

    }
}