using EnterpriseICETASK2.Models;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseICETASK2.Data
{
    public class EnterpriseIceTask2Db : DbContext
    {

        public EnterpriseIceTask2Db(DbContextOptions<EnterpriseIceTask2Db> options) : base(options) { }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
