﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Project.Models
{
    internal class Category
    {
        public int ID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
