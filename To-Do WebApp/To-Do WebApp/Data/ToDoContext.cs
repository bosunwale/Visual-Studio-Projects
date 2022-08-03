using Microsoft.EntityFrameworkCore;
using To_Do_WebApp.Models;

namespace To_Do_WebApp.Data
{
    public class ToDoContext : DbContext
    {
        /**
         *Constructor that handles the path for storing
         *the database file locally
         */
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {

        }

        public DbSet<ToDo> ToDo { get; set; }
    }
}
