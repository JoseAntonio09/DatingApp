using InAndOut.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InAndOut.Data
{

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }
        public DbSet<Items> Items { get; set; }

        public DbSet<Expense> Expenses { get; set; }
     
        public DbSet<ExpenseType> ExpenseTypes { get; set; }


    }

}


