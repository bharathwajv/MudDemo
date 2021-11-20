using MudDemo.Client.Models;

namespace MudDemo.Client.Services;

public interface IUserService
{
    Task<IEnumerable<UserModel>> GetUserInfo();
}