using FinanceApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<FinancialInstitution> Institutions { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

    }
}
