﻿using StudentCORE;
using StudentDAL.Context;
using StudentDAL.Repository;
using StudentENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDAL
{
    public class LessonRepository : EntityRepository<Lesson, ApplicationContext>, ILessonRepository
    {
    }
}
