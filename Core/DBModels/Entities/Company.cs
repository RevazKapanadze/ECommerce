using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.DBModels
{
    public class Company
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? NameForUrl { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public string? LocationUrl { get; set; }
        public bool IsActive { get; set; }
        public bool IsPaid { get; set; }
        public bool IsDeleted { get; set; }
        public bool HasMainCategory { get; set; }
        public int PaymentDay { get; set; }
        public string? ThemeColour { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public User? Creator { get; set; }
        public ICollection<UserCompany>? UserCompanies { get; set; } = new List<UserCompany>();
    }
}
