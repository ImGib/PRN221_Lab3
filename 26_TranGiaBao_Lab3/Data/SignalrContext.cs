using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _26_TranGiaBao_Lab3.Models;

namespace _26_TranGiaBao_Lab3.Data
{
    public class SignalrContext : DbContext
    {
        public SignalrContext (DbContextOptions<SignalrContext> options)
            : base(options)
        {
        }

        public DbSet<_26_TranGiaBao_Lab3.Models.Products> Products { get; set; } = default!;
    }
}
