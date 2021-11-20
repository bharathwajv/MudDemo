using Microsoft.AspNetCore.Components;
using MudBlazor;
using MudBlazor.Utilities;
using MudDemo.Client.Models.Article;
using MudDemo.Client.Services;

namespace MudDemo.Client.Components.Index;

public partial class ArticleCarousel : MudComponentBase
{
    [Inject] private IArticlesService ArticlesService { get; set; }

    private List<ArticlePreviewModel> _articles = new();

    private int _selectedArticle = 0;

    private string Classname =>
        new CssBuilder()
            .AddClass(Class)
            .Build();
    protected override async Task OnInitializedAsync()
    {
        //_articles = (await ArticlesService.GetArticles()).ToList();
    }
    private void NavigatePrevious()
    {
        if (_selectedArticle == 0)
            _selectedArticle = _articles.Count - 1;
        else
            _selectedArticle--;
    }

    private void NavigateNext()
    {
        if (_selectedArticle == _articles.Count - 1)
            _selectedArticle = 0;
        else
            _selectedArticle++;
    }
}