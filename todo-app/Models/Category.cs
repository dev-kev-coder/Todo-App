namespace todo_app.Models
{
    public class Category
    {
        public int? CategoryID { get; set; }

        public string? CategoryName { get; set; }

        public List<TaskItem>? TaskItems { get; set; }

        public DateTime? DateTimeCreated { get; set; } = DateTime.Now;

        public DateTime? DateTimeModified { get; set; }

        public DateTime? DateTimeDeleted { get; set; }

        public ApplicationUser? ApplicationUser { get; set; }
    }
}
