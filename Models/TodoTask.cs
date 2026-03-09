namespace TaskManager.Models
{
    using System.ComponentModel.DataAnnotations;
    public class TodoTask
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title can't exceed 100 characters")]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public bool IsCompleted { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
    }
}
