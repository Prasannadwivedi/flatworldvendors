using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using flatworldvendor.Models;

namespace flatworldvendor.Data
{
    public class flatworldvendorContext : DbContext
    {
        public flatworldvendorContext (DbContextOptions<flatworldvendorContext> options)
            : base(options)
        {
        }

        public DbSet<flatworldvendor.Models.User1> User1 { get; set; } = default!;

        public DbSet<flatworldvendor.Models.Partner> Partner { get; set; }

        public DbSet<flatworldvendor.Models.ProjectManager> ProjectManager { get; set; }

        public DbSet<flatworldvendor.Models.Requistion> Requistion { get; set; }

        public DbSet<flatworldvendor.Models.Resource> Resource { get; set; }
    }
}
