namespace LegacyApplication;

public static class UserService
{
    public static async Task<bool> AddUser(string username, string emailAddress, string fullname)
    {
        if (string.IsNullOrEmpty(username))
        {
            return false;
        }

        if (string.IsNullOrEmpty(emailAddress))
        {
            return false;
        }

        if (string.IsNullOrEmpty(fullname))
        {
            return false;
        }

        if (!emailAddress.Contains('@'))
        {
            return false;
        }

        var emailValidator = new EmailValidator();

        if (!await emailValidator.ValidateEmailAddress(emailAddress))
        {
            return false;
        }
        
        var respository = new UserRepository();

        var user = new User
        {
            EmailAddress = emailAddress,
            FullName = fullname,
            Username = username,
            CreatedOn = DateTime.Now
        };
        
        respository.Add(user);

        return true;
    }

    public static async Task<List<User>> GetAllUsers()
    {
        var repository = new UserRepository();

        return await repository.GetAllUsers();
    }
}