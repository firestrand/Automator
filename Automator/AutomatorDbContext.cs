using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Automator
{
    public class AutomatorDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; } 
    }
}
