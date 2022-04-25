using Contacts.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Contacts.DataAccess
{
    public class ContactsDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-H45A4ON; Database=ContactsDb;uid=sefa;password=sefa");
        }
        public DbSet<User> Users{ get; set; }
    }
}
