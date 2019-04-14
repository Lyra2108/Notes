using Microsoft.EntityFrameworkCore;
using Notes.Storage.Model;

namespace Notes.Storage
{
    public class NotesContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=notes.db");
        }
    }
}