namespace translator_app.Views;

public partial class LoadingPage : UraniumUI.Pages.UraniumContentPage
{
    private readonly IAuthenticateService _authenticateService;

    public LoadingPage()
    {
        InitializeComponent();
        _authenticateService = ServiceHelper.GetService<IAuthenticateService>();
    }

    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        if (await _authenticateService.IsAuthenticateAsync())
        {
            // user is logged in
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
        else
        {
            // not login
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
