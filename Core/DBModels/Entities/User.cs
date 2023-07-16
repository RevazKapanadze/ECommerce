
using Microsoft.AspNetCore.Identity;
namespace Core.DBModels
{
    public class User : IdentityUser
    {
        public DateTime RegisterDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsBlocked { get; set; }
        public bool? IsDeleted { get; set; }
        public ICollection<Company>? Companies { get; set; }
        public ICollection<UserCompany>? UserCompanies { get; set; } = new List<UserCompany>();
    }
}
