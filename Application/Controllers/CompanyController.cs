
using Application.Dtos;
using Core.DBModels.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Application.Controllers
{
    [Authorize(Roles = "User")]
    [Route("api/company")]
    public class CompanyController : BaseController
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly UserManager<User> _userManager;
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyRepository companyRepository, UserManager<User> userManager, ICompanyService companyService)
        {
            _companyRepository = companyRepository;
            _userManager = userManager;
            _companyService = companyService;
        }
        [HttpPost("create-company")]
        public async Task<IActionResult> CreateCompany(CompanyDto companyDto)
        {
            var user = await _userManager.FindByNameAsync(User.Identity?.Name);
            var userId = user?.Id;
            var company = new Company
            {
                Id = Guid.NewGuid(),
                Name = companyDto.Name,
                NameForUrl = companyDto.NameForUrl,
                LocationUrl = companyDto.LocationUrl,
                PaymentDay = companyDto.PaymentDay,
                ThemeColour = companyDto.ThemeColour,
                Location = companyDto.Location,
                Description = companyDto.Description,
                IsActive = true,
                IsPaid = true,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                CreatedBy = userId
            };
            await _companyRepository.CreateCompany(company, userId);
            return Ok();
        }
        [HttpGet("get-all-companies")]
        public async Task<IActionResult> GetAllCompanies()
        {
            var user = await _userManager.FindByNameAsync(User.Identity?.Name);
            var userId = user?.Id;
            var resut = await _companyService.GetAllCompanies(userId);
            return Ok(resut);
        }
    }
}
