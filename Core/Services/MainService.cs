using AutoMapper;
using Core.DBModels;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;
using Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class MainService : IMainService
    {
        private readonly IMainRepository _repository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        public MainService(IMainRepository repository, ICompanyRepository companyRepository, IMapper mapper)
        {
            _repository = repository;
            _companyRepository = companyRepository;
            _mapper = mapper;
        }
        public async Task<List<CompanyViewModel>> GetAllCompanies()
        {

            var list = await _companyRepository.GetAllCompanies(null);
            var result = list.Map<Company?, CompanyViewModel>(_mapper);
            return result;
        }
    }
}
