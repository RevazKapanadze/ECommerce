using Core.DBModels.Entities;
using Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context) { }
        public async Task CreateCompany(Company company, string userId)
        {
            await Context.Companies.AddAsync(company);
            await Context.UserCompanies.AddAsync(new UserCompany { UserId = userId, CompanyId = company.Id });
            await Context.SaveChangesAsync();
        }

        public async Task<List<Company>> GetAllCompanies(string? userId)
        {
            var query = GetCompanyQuery();
            if (!string.IsNullOrEmpty(userId))
            {
                query = query.Include(i => i.UserCompanies)
                .Where(c => c.UserCompanies.Any(u => u.UserId == userId));
            }
            return await query.ToListAsync();

        }
        private IQueryable<Company> GetCompanyQuery()
        {
            return Context.Companies.Where(i => i.IsActive && !i.IsDeleted && i.IsPaid).AsNoTracking();
        }
    } 
}
