using Microsoft.EntityFrameworkCore;

namespace To_Do_WebApp.Models
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDo> todoDb { get; set; }
        public string DbPath { get; }

        /**
         *Constructor that handles the path for storing
         *the database file locally
         */
        public ToDoContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "todo.db");
        }

        //Configuring EF to create an sqlite database file in the
        //special local folder 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source = {DbPath}");
    }

    /**
     *SQlite will build the entity and attributes
     *usiing the variables declared in this class
     */
    public class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isDone { get; set; }
    }
}
