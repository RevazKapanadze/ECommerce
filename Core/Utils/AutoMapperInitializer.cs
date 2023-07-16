using AutoMapper;
using Core.Configurations.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils
{
    public static class AutoMapperInitializer
    {
        public static MapperConfiguration Initialize()
        {
            var configuration = new MapperConfiguration(mapperconfig =>
            {
                mapperconfig.AddProfile<CompanyMapping>();
            });
            return configuration;
        }
    }
}
