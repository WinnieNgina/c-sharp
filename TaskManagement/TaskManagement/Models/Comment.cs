using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class Comment:BaseModels
    {
        public ProjectTasks Tasks { get; set; }
        public string TaskId { get; set; }
        public string Content { get; set; }
    }
}
