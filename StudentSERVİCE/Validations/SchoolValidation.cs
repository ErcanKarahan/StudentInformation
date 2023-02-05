﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StudentENTITIES;

namespace StudentSERVİCE.Validations
{
    public class SchoolValidation:AbstractValidator<School>
    {
        public SchoolValidation()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
