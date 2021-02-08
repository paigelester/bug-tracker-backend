using BugTracker.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Infrastructure
{
    public class BugTrackerContext : DbContext
    {
        public BugTrackerContext(DbContextOptions<BugTrackerContext> options) : base(options) {}

        public DbSet<Project> Projects { get; set; }
    }
}
