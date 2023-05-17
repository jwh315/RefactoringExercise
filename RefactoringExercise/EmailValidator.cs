namespace RefactoringExercise;

public class EmailValidator
{
    public async Task<bool> ValidateEmailAddress(string emailAddress)
    {
        var httpClient = new HttpClient();

        var url = "http://localhost:8080/validate?email=" + emailAddress;

        var result = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, url));

        return result.IsSuccessStatusCode;
    }
}