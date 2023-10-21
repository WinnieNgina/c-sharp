using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using Microsoft.Identity.Client;

namespace TaskManagement.Models
{
    public class Project:BaseModels
    {
        public string projectName { get; set; }
        public string projectVersion { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string status { get; set; }
        public ICollection<ProjectTasks> tasks { get; set; }

    }
}
