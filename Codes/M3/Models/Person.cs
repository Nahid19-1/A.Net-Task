﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M3.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string BloodGrp { get; set; }
    }
}