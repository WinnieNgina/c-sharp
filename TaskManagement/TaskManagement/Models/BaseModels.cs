namespace TaskManagement.Models
{
    public abstract class BaseModels
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set;}


    }
}
