using System.Text.Json;
using Bogus;
using Microsoft.Extensions.Hosting;
using RefactoringExercise;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
    })
    .Build();

for (var i = 0; i < 50; i++)
{
    var faker = new Faker();

    var username = faker.Person.UserName;
    var emailAddress = faker.Person.Email;
    var fullName = faker.Person.FullName;

    var created = await UserService.AddUser(username, emailAddress, fullName);

    if (!created)
    {
        throw new Exception("User could not be created, we do not know why");
    }
}

Console.WriteLine("User was successfully created");

var users = await UserService.GetAllUsers();
    
users.ForEach(u => Console.WriteLine(JsonSerializer.Serialize(u)));
