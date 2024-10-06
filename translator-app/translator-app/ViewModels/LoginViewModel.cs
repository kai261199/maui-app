namespace translator_app.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        [ObservableProperty]
        LoginModel loginModel;

        private readonly IAuthenticateService _authenticateService;

        public LoginViewModel(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }


        [RelayCommand]
        async Task Login()
        {
            _authenticateService.Login();
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
    }
}
