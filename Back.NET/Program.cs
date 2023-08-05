namespace Back.NET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //services
            builder.Services
                .AddControllersWithViews()
                .AddRazorRuntimeCompilation();
            var app = builder.Build();


            //Middleware
            app.UseStaticFiles();
            app.MapControllerRoute("default","{controller=Book}/{action=Index}");

            app.Run();
        }

    }
}