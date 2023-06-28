using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudInASP.Models;

namespace CrudInASP.Data
{
    public class CrudInASPContext : DbContext
    {
        public CrudInASPContext (DbContextOptions<CrudInASPContext> options)
            : base(options)
        {
        }

        public DbSet<CrudInASP.Models.Employee> Employee { get; set; } = default!;
    }
}
