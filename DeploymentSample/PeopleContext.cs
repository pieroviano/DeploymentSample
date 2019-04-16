using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DeploymentSample.Models;

namespace DeploymentSample
{
    public class PeopleContext : DbContext  
    {
        public PeopleContext() : base("ConnectionString")
        {

        }

        public DbSet<Person> People { get; set; }
    }
}