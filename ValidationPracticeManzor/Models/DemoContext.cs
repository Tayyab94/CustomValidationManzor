using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ValidationPracticeManzor.Models
{
    public class DemoContext:DbContext
    {
        public DemoContext():base("V")
        {

        }

        public DbSet<Department> Departments { get; set; }
    }
}