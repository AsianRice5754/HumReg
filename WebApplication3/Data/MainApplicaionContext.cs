using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MainApplicaion.Models;

namespace MainApplicaion.Data
{
    public class MainApplicaionContext : DbContext
    {
        public MainApplicaionContext (DbContextOptions<MainApplicaionContext> options)
            : base(options)
        {

        }

        public DbSet<HumReg> HumReg { get; set; }
    }
}
