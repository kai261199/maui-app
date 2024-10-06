namespace translator_app.Views;

public partial class DiagnosticPage : UraniumUI.Pages.UraniumContentPage
{
    public DiagnosticPage(DiagnosticViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
