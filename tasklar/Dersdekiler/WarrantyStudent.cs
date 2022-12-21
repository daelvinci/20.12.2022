﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dersdekiler
{
    internal class WarrantyStudent:Student
    {
        public WarrantyStudent(string name, string surname, string prevGroupNo) : base(name, surname)
        {
            PrevGroupNo = prevGroupNo;
        }
        public string PrevGroupNo;
    }
}
