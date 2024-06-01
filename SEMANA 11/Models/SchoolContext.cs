using Microsoft.EntityFrameworkCore;
using SEMANA_11.Models;

namespace SEMANA_11.Models
{
    public class SchoolContext : DbContext
    {

        public DbSet<Student> Students { get; set; }

        public DbSet<Grade> Grades { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1504-04\\SQLEXPRESS;" +
                "Initial Catalog=SchoolDB; Integrated Security=True;trustservercertificate=True");
        }


        public DbSet<SEMANA_11.Models.Course> Course { get; set; } = default!;





    }
}
