using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class CompanyViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? NameForUrl { get; set; }
        
        public string? ThemeColour { get; set; }
    }
}
