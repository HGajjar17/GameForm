using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameForm.Models;

namespace GameForm.Data
{
    public class GameFormContext : DbContext
    {
        public GameFormContext (DbContextOptions<GameFormContext> options)
            : base(options)
        {
        }

        public DbSet<GameForm.Models.Discussion> Discussion { get; set; } = default!;
        public DbSet<GameForm.Models.Comment> Comment { get; set; } = default!;
    }
}
