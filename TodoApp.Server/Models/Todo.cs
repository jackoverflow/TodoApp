namespace TodoApp.Server.Models {
    class Todo {
        public int Id { get; set; }
        public string Task { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}