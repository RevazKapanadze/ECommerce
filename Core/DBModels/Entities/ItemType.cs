using Core.DBModels.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DBModels
{
    public class ItemType //ხელთათმანი ჩაფხუტი
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid CompanyId { get; set; }
        public ICollection<Item>? Items { get; set; } = new List<Item>();
        public ICollection<ItemTypeFilter>? ItemTypeFilters { get; set; } = new List<ItemTypeFilter>();
    }
}