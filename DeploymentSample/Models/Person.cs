﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeploymentSample.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
    }
}