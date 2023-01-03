using Microsoft.EntityFrameworkCore;
using NKWalks.API.Models.Domain;

namespace NKWalks.API.Data
{
    public class NKWalksDbContext : DbContext
    {
        public NKWalksDbContext(DbContextOptions<NKWalksDbContext> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }//if table does not exist then will create table by entity

        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> WalkDifficulties { get; set; }
    }
}
