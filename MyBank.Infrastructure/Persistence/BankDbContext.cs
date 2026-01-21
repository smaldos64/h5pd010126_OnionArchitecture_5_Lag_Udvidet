using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyBank.Domain.Model.Entities;

namespace MyBank.Infrastructure.Persistence
{
    public class BankDbContext : DbContext
    {
        public BankDbContext(DbContextOptions<BankDbContext> opt) : base(opt) { }
        public DbSet<Account> Accounts { get; set; }
    }
}
