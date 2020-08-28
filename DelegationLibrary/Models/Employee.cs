﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DelegationLibrary.Model
{
    public class Employee : Person, IEmployee
    {
        public int EmployeeID { get; set; }

        [Display(Name = "Wyjazdy")]
        public List<IBusinessTrip> Trips { get; set; }

    }
}
