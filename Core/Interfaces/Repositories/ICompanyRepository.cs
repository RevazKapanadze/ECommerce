using Core.DBModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface ICompanyRepository
    {
        Task CreateCompany(Company company, string userId);
        Task<List<Company>> GetAllCompanies(string? userId);
    }
}
