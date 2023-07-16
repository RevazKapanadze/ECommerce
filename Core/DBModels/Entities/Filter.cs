using Core.DBModels.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DBModels
{
    public class Filter //ზომა ფერი
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public ICollection<ItemTypeFilter>? ItemTypeFilters { get; set; } = new List<ItemTypeFilter>();
        public ICollection<ItemQuantityFilter> ItemQuantityFilters { get; set; } = new List<ItemQuantityFilter>();
    }
}
