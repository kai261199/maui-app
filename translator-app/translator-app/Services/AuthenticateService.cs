
namespace translator_app.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private const string AuthStateKey = "AuthSate";
        public async Task<bool> IsAuthenticateAsync()
        {
            await Task.Delay(2000);
            var authState = Preferences.Default.Get<bool>(AuthStateKey, false);
            return authState;
        }

        public void Login()
        {
            Preferences.Default.Set<bool>(AuthStateKey, true);
        }

        public void Logout()
        {
            Preferences.Default.Set<bool>(AuthStateKey, false);
        }

    }
}