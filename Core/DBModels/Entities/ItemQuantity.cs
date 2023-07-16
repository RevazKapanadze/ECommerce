using Core.DBModels.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DBModels
{
    public class ItemQuantity
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public int Quantity { get; set; }
        public Item? Item { get; set; }
        public ICollection<ItemQuantityFilter> ItemQuantityFilters { get; set; } = new List<ItemQuantityFilter>();
    }
}
