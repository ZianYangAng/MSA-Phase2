using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ChadAPI.Models
{
    public class ChadAPIContext : DbContext
    {
        public ChadAPIContext (DbContextOptions<ChadAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ChadAPI.Models.MemeItem> MemeItem { get; set; }
    }
}
