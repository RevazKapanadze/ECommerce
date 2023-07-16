using AutoMapper;
using Core.DBModels.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;
using Core.Utils;
namespace Core.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }
        public async Task<List<CompanyViewModel>> GetAllCompanies(string userId)
        {

            var list = await _companyRepository.GetAllCompanies(userId);
            var result = list.Map<Company?, CompanyViewModel>(_mapper);
            return result;
        }

    }
}
