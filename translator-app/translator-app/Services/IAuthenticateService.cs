namespace translator_app.Services
{
    public interface IAuthenticateService : ITransient
    {
        Task<bool> IsAuthenticateAsync();

        void Login();

        void Logout();
    }
}
