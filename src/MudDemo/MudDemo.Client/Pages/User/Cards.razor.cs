using Microsoft.AspNetCore.Components;
using MudBlazor;
using MudDemo.Client.Models;
using MudDemo.Client.Services;

namespace MudDemo.Client.Components.Shared;

public partial class CardsBase : MudComponentBase
{
    public IEnumerable<UserModel> _users ;

    [Inject] private IUserService UserService { get; set; }


    protected override async Task OnInitializedAsync()
    {
       // _users = await UserService.GetUserInfo();
    }
}