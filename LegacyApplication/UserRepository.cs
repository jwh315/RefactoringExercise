using Microsoft.EntityFrameworkCore;

namespace LegacyApplication;

public class UserRepository
{
    public static ApplicationDbContext DbContext { get; set; }
    
    public UserRepository()
    {
        if (DbContext is null)
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
        
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
        
            var options = builder.Options;

            DbContext = new ApplicationDbContext(options);
        }
    }
    
    public void Add(User user)
    {
        DbContext.Users.Add(user);

        DbContext.SaveChanges();
    }

    public async Task<List<User>> GetAllUsers()
    {
        return await DbContext.Users.ToListAsync();
    }
}