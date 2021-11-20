using System.Net.Http.Json;
using MudDemo.Client.Models;

namespace MudDemo.Client.Services;

public class UserService : IUserService
{
    private const string UriRequest = "sample-data/users.json";
    private readonly HttpClient _httpClient;

    public UserService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<IEnumerable<UserModel>> GetUserInfo()
    {
        var users = await _httpClient.GetFromJsonAsync<IEnumerable<UserModel>>(UriRequest);
        return users ?? throw new InvalidOperationException();
    }
}