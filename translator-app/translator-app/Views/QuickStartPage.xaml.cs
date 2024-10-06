namespace translator_app.Views;

public partial class QuickStartPage : UraniumUI.Pages.UraniumContentPage
{
    public QuickStartPage(QuickStartViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
