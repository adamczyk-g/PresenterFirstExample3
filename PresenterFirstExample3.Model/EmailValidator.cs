﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresenterFirstExample3.Model
{
    public interface EmailValidator
    {
        bool Validate(string email);
    }
}
