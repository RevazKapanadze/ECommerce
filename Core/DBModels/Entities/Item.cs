using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DBModels
{
    public class Item
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string? ShortName { get; set; }
        public Guid DescriptionId { get; set; }
        public Guid ItemTypeId { get; set; }
        public ItemType? ItemType { get; set; }
        public ICollection<ItemMainCategory>? ItemMainCategories { get; set; } = new List<ItemMainCategory>();
        public ICollection<ItemQuantity> ItemQuantities { get; set; } = new List<ItemQuantity>();
    }
}
