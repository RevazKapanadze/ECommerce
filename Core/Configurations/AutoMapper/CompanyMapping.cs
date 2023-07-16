using AutoMapper;
using Core.DBModels.Entities;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
