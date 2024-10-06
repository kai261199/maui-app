namespace translator_app.Views;

public partial class LoginPage : UraniumUI.Pages.UraniumContentPage
{
    public LoginPage(LoginViewModel vm) :base()
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
