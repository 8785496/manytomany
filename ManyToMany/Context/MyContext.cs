using ManyToMany.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManyToMany.Context
{
    public class MyContext : System.Data.Entity.DbContext
    {
        public MyContext() : base() { }

        public MyContext(String connectString) : base(connectString)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MyContext>());
        }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}