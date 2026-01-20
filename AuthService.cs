public class AuthService
{
    HttpClient _client = new();

    public async Task Login(string email, string password)
    {
        var res = await _client.PostAsJsonAsync(
            "https://api.truckerback.com/auth/login",
            new { email, password });

        var token = (await res.Content.ReadFromJsonAsync<dynamic>()).token;
        await SecureStorage.SetAsync("token", token);
    }
}
