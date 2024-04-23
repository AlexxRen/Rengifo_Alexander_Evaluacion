using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rengifo_Alexander.Models;

namespace Rengifo_Alexander.Data
{
    public class Rengifo_AlexanderContext : DbContext
    {
        public Rengifo_AlexanderContext (DbContextOptions<Rengifo_AlexanderContext> options)
            : base(options)
        {
        }

        public DbSet<Rengifo_Alexander.Models.ARengifo> ARengifo { get; set; } = default!;
    }
}
