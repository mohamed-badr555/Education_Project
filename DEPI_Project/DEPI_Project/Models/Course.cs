﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Project.Models
{
    internal class Course
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(30)]
        public string Level { get; set; }
        public int N_Lessons { get; set; }
        [MaxLength(500)]
        public string Path { get; set; }
        public float Price { get; set; }
        public bool IsFree { get; set; }
        public float Rating { get; set; }
        [MaxLength(2000)]
        public string? Description { get; set; }
        [MaxLength(1500)]
        public string? About { get; set; }//Note
        [MaxLength(50)]
        public string Duration { get; set; }
        public DateTime Last_Update { get; set; }
        public bool IsPublished { get; set; }
        public int Intro_Video { get; set; }
        [MaxLength(300)]
        public string? Details { get; set; }
        public int Num_Units { get; set; }


        #region Category - Course (1-M)
        public int CategoryID { get; set; } //Foreign key
        public Category Categories { get; set; }
        #endregion

        #region Course - CourseUnit (1-M)
        public ICollection<CourseUnit> CourseUnits { get; set; }
        #endregion

        #region Course - Account (M-M)
        public ICollection<CourseAccount> CourseAccounts { get; set; } 
        #endregion
    }
}
