
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DBModels
{
    public class MainCategory //კაცის ქალის ბავშვის
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid CompanyId { get; set; }
        public ICollection<ItemMainCategory>? ItemMainCategories { get; set; } = new List<ItemMainCategory>();
    }
}
