using BugTracker.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker.Infrastructure
{
    public class BugTrackerContext : DbContext
    {
        public BugTrackerContext(DbContextOptions<BugTrackerContext> options) : base (options)
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}
