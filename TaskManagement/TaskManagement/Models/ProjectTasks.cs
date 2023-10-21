using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;
using System;

namespace TaskManagement.Models
{
    public class ProjectTasks:BaseModels
    {
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus Status { get; set; }
        public string AssignedTo { get; set; }
        public Project TasksProject { get; set; }
        public string ProjectId { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
    public enum ProjectStatus {
        Canceled,Completed,InProgress
    
    }

}
