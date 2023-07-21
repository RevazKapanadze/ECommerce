using Core.DBModels;
using Core.DBModels.ManyToMany;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

public class AppDbContext : IdentityDbContext<User, IdentityRole, string, IdentityUserClaim<string>, IdentityUserRole<string>, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Company> Companies { get; set; }
    public DbSet<UserCompany> UserCompanies { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Company>()
        .HasOne(c => c.Creator)
        .WithMany(u => u.Companies)
        .HasForeignKey(c => c.CreatedBy);

        builder.Entity<Company>()
        .HasIndex(c => c.Name)
        .IsUnique();

        /*builder.Entity<UserCompany>()
            .HasKey(uc => new { uc.UserId, uc.CompanyId });

        builder.Entity<UserCompany>()
            .HasOne(uc => uc.User)
            .WithMany(u => u.UserCompanies)
            .HasForeignKey(uc => uc.UserId);

        builder.Entity<UserCompany>()
            .HasOne(uc => uc.Company)
            .WithMany(c => c.UserCompanies)
            .HasForeignKey(uc => uc.CompanyId);*/
        builder.Entity<User>(entity =>
         {
             entity.ToTable(name: "Users"); // Change the table name to "Users"
         });

        builder.Entity<IdentityRole>(entity =>
        {
            entity.ToTable(name: "Roles"); // Change the table name to "Roles"
        });

        builder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.ToTable(name: "UserRoles"); // Change the table name to "UserRoles"
        });

        builder.Entity<IdentityUserClaim<string>>(entity =>
        {
            entity.ToTable(name: "UserClaims"); // Change the table name to "UserClaims"
        });

        builder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.ToTable(name: "UserLogins"); // Change the table name to "UserLogins"
        });

        builder.Entity<IdentityRoleClaim<string>>(entity =>
        {
            entity.ToTable(name: "RoleClaims"); // Change the table name to "RoleClaims"
        });

        builder.Entity<IdentityUserToken<string>>(entity =>
        {
            entity.ToTable(name: "UserTokens"); // Change the table name to "UserTokens"
        });
    }
}
