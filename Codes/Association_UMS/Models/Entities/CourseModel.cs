﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Association_UMS.Models.Entities
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OfferedBy { get; set; }
    }
}