using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core;
using System.Windows.Media.Animation;
using System.Configuration;

namespace SchoolProject.Models.DbContext
{
    public class SchoolDbContext : System.Data.Entity.DbContext
    {
        public DbSet<tbl_User> Users { get; set; }
        public DbSet<tbl_Patient> patient { get; set; }
        public DbSet<tbl_Roles> roles { get; set; }
        public DbSet<tbl_Study> Study { get; set; }

        public DbSet<tbl_Series> Series { get; set; }
        public DbSet<tbl_Images> Images { get; set; }
        public DbSet<tbl_Reports> Reports { get; set; }
        public DbSet<tbl_Videos> Videos { get; set; }



        public SchoolDbContext() : base("name=SQLConnection")
        {
        }
    }
}
