namespace translator_app.Views;

public partial class SettingPage : UraniumUI.Pages.UraniumContentPage
{
    public SettingPage(SettingViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
