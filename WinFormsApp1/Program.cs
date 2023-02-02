namespace WinFormsApp1
{
	using Microsoft.Extensions.DependencyInjection;

	using WinFormsApp1.Forms;

	internal static class Program
	{
		public static IServiceProvider ServiceProvider { get; private set; }

		/// <summary>
		/// سرویسها
		/// </summary>
		static void ConfigureServices()
		{
			var services = new ServiceCollection();

			//services.AddScoped<IDataBaseContext, DataBaseContext>();
			//services.AddScoped<IAddNewContactService, AddNewContactService>();
			Hesabdar.Application.ApplicationServicesRgistration.ConfigureApplicationServices(services);

			//services.AddDbContext<DataBaseContext>();

			ServiceProvider = services.BuildServiceProvider();

		}

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new frmMain());
		}
	}
}