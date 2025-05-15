using Microsoft.Extensions.DependencyInjection;
using ProductTrackerApp.Forms;
using ProductTrackerApp.Models;
using ProductTrackerApp.Services;

namespace ProductTrackerApp
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configure DI  
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Build service provider  
            ServiceProvider = services.BuildServiceProvider();

            // Resolve and run LoginForm  
            using(var loginForm = ServiceProvider.GetRequiredService<LoginForm>())
        {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Form dashboardForm = DataStore.CurrentUser!.Role == Role.Administrator
                        ? ServiceProvider.GetRequiredService<AdminDashboard>()
                        : ServiceProvider.GetRequiredService<UserDashboard>();
                    Application.Run(dashboardForm);
                }
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Register services  
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<ISuggestionService, SuggestionService>();

            // Register forms as services (to enable DI)  
            services.AddTransient<LoginForm>();
            services.AddTransient<UserDashboard>();
            services.AddTransient<AdminDashboard>();
            services.AddTransient<SuggestionForm>();
        }
    }
}