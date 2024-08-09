using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;
using MVCWithEFCF3.Models;

namespace MVCWithEFCF3.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SchoolDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SchoolDBContext context)
        {
            // Seed data if necessary
        }
    }
}