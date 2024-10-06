namespace translator_app.Views;

public partial class HomePage : UraniumUI.Pages.UraniumContentPage
{
    private readonly IAuthenticateService _authenticateService;
    public HomePage(HomeViewModel vm, IAuthenticateService authenticateService)
    {
        InitializeComponent();
        BindingContext = vm;
        _authenticateService = authenticateService;

    }


    private void LogOut_Clicked(object sender, EventArgs e)
    {
        _authenticateService.Logout();
        Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}
