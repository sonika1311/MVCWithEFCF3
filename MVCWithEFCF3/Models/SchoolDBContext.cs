using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCWithEFCF3.Models
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext() : base("ConStr")
        {

        }
        public DbSet<Student> Students
        {
            get; set;
        }
    }
}