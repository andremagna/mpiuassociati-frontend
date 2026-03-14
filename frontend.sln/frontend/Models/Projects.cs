using System;
using System.Collections.Generic;

namespace frontend.Models
{
    public class Projects
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectPlace { get; set; }
        public DateTime ProjectYear { get; set; }
        public string ProjectParentFilter { get; set; }
        public string ProjectChildFilter { get; set; }
        public string ProjectCover { get; set; }
        public List<string> ProjectImages { get; set; }
    }
}