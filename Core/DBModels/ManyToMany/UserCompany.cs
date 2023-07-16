using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DBModels;

namespace Core.DBModels
{
    public class UserCompany
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public User? User { get; set; } = null;

        public Guid CompanyId { get; set; }
        public Company? Company { get; set; } = null;
    }
}
