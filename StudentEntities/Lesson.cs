﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentENTITIES
{
    public class Lesson : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TeacherId { get; set; }
  

    }
}
