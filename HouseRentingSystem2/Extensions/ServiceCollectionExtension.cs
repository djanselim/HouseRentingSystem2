using HouseRentingSystem.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class ServiceCollectionExtension
	{
		public static IServiceCollection AddApplicatonServices(this IServiceCollection services)
		{
			return services;
		}

		public static IServiceCollection AddApplicatonDbContext(this IServiceCollection services, IConfiguration config)
		{
			var connectionString = config.GetConnectionString("DefaultConnection");
			services.AddDbContext<HouseRentingDbContext>(options =>
				options.UseSqlServer(connectionString));

			services.AddDatabaseDeveloperPageExceptionFilter();

			return services;
		}
		public static IServiceCollection AddApplicatonIdentity(this IServiceCollection services, IConfiguration config)
		{
			services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
				.AddEntityFrameworkStores<HouseRentingDbContext>();

			return services;
		}

	}
}
