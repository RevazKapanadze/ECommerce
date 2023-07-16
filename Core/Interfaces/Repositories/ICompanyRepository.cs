using Core.DBModels;

namespace Core.Interfaces.Repositories
{
    public interface ICompanyRepository
    {
        Task CreateCompany(Company company, string userId);
        Task<List<Company>> GetAllCompanies(string? userId);
    }
}
