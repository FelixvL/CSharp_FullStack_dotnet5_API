using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDatabaseVerbinding
{
    public class DataBaseContextVerbinding : DbContext
    {
        public DataBaseContextVerbinding(DbContextOptions opt) : base(opt) { }
        public DbSet<Kok> koks { get; set; }
    }
}
