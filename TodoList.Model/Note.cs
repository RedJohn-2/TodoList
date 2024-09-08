namespace TodoList.Model
{
    public class Note
    {
        public long Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public bool IsComplited { get; set; }
    }
}
