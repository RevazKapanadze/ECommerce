
using Core.DBModels.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Context
{
    public static class DbInitializer
    {
        public static async Task Initialize(AppDbContext context, UserManager<User> userManager)
        {
            if (!context.Roles.Any())
            {
                var roles = new List<IdentityRole>
                {
                    new IdentityRole { Name = "Client", NormalizedName = "CLIENT" },
                    new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                    new IdentityRole { Name = "User", NormalizedName = "USER" }
                };
                await context.Roles.AddRangeAsync(roles);
            }
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "admin",
                    Email = "admin@gmail.com"
                };
                await userManager.CreateAsync(user, "Pa$$W0rd");
                await userManager.AddToRoleAsync(user, "Admin");
            }

            await context.SaveChangesAsync();
        }
    }
}
