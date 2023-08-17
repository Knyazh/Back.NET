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


            //middleware
            app.UseStaticFiles();
            app.MapControllerRoute("default", "{controller=home}/{action=index}");

            app.Run();
        }

    }
}
