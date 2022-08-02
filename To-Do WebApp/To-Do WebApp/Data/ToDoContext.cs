using Microsoft.EntityFrameworkCore;
using To_Do_WebApp.Models;

namespace To_Do_WebApp.Data
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDo> toDo { get; set; }

        public string DbPath { get; }

        /**
         *Constructor that handles the path for storing
         *the database file locally
         */
        public ToDoContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "mytodo.db");
        }

        //Configuring EF to create an sqlite database file in the
        //special local folder 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source = {DbPath}");
    }
}
