using Microsoft.EntityFrameworkCore;

namespace RefactoringExercise;

public class ApplicationDbContext: DbContext
{
    public DbSet<User> Users { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}