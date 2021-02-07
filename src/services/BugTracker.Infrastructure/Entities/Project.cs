using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker.Infrastructure.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
    }
}
