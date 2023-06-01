namespace todo_app.Models
{
    public class TaskItem
    {
        public int? TaskItemID { get; set; }

        public Category? Category { get; set; }  

        public string? TaskItemDescription { get; set; }

        public bool? Complete { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        public string? Notes { get; set; }
        public DateTime? DateTimeCreated { get; set; } = DateTime.Now;

        public DateTime? DateTimeModified { get; set; }

        public DateTime? DateTimeDeleted { get; set; }
    }
}
