using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Hesabdar.Application
{
	public static class ApplicationServicesRgistration
	{
		public static void ConfigureApplicationServices(this IServiceCollection services)
		{
			//services.AddAutoMapper(typeof(MappingProfile));
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
		}
	}
}
