namespace translator_app.Models
{
    public partial class LoginModel : ObservableObject
    {
        [ObservableProperty]
        public string token;
    }
}
