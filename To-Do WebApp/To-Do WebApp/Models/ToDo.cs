namespace To_Do_WebApp.Models
{
    public class ToDo
    {
        /**
     *SQlite will build the entity and attributes
     *usiing the variables declared in this class
     */
        public int Id { get; set; }
        public string Name { get; set; }
        public Boolean isDone { get; set; }
        public DateTime AddDate { get; set; }
        public List<ToDo> ToDoList { get; } = new();
    }
}
