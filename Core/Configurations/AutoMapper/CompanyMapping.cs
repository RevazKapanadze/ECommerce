using AutoMapper;
using Core.DBModels;
using Core.Models;

namespace Core.Configurations.AutoMapper
{
    public class CompanyMapping : Profile
    {
        public CompanyMapping()
        {
            CreateMap<Company?, CompanyViewModel>(MemberList.None);
        }
    }
}
