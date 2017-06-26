using lsyi.Models.SystemMoels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace lsyi.Data.Context
{
    public class LsyiObjectContext : DbContext
    {

        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=lsy-pc; Initial Catalog=dbCore; User ID=sa;Password=sql;");
        }

    }
}
