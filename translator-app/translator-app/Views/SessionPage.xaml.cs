namespace translator_app.Views;

public partial class SessionPage : UraniumUI.Pages.UraniumContentPage
{
    public SessionPage(SessionViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
