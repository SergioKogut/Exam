using System.Data.Entity;
using TestSystem.Entities;

namespace TestSystem
{
    public class EFContext : DbContext
    {
        public EFContext() : base("ConnStr")
        {

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Test> Tests { get; set; }

    }
}
