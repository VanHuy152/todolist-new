namespace TodoApi.Models
{
    public class TodoItem //Todo
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
