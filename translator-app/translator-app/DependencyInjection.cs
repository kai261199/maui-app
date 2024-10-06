namespace translator_app
{
    public static class DependencyInjection
    {
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.Scan(i => i
                                        .FromCallingAssembly()
                                        .AddClasses(c => c.AssignableTo<ITransient>())
                                        .AsImplementedInterfaces()
                                        .WithTransientLifetime()

                                        .AddClasses(c => c.AssignableTo<IScoped>())
                                        .AsImplementedInterfaces()
                                        .WithScopedLifetime()

                                        .AddClasses(c => c.AssignableTo<ISingleton>())
                                        .AsImplementedInterfaces()
                                        .WithSingletonLifetime());
            return builder;
        }

        /// <summary>
        /// Auto Regist all VIEWS of app which implemented from ContentPage with singleton life time
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
        {
            builder.Services.Scan(i => i
                                        .FromCallingAssembly()
                                        .AddClasses(c => c.AssignableTo<ContentPage>())
                                        .AsSelf()
                                        .WithSingletonLifetime());
            return builder;
        }

        /// <summary>
        /// Auto Regist all viewmodel of app which implemented from BaseViewModel with singleton life time
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            builder.Services.Scan(i => i
                                        .FromCallingAssembly()
                                        .AddClasses(c => c.AssignableTo<BaseViewModel>())
                                        .AsSelf()
                                        .WithTransientLifetime());
            return builder;
        }
    }
}
