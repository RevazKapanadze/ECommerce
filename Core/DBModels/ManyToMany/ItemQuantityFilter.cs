using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DBModels.ManyToMany
{
    public class ItemQuantityFilter
    {
        public Guid Id { get; set; }
        public Guid ItemQuantityId { get; set; }
        public ItemQuantity? ItemQuantity { get; set; }
        public Guid FilterId { get; set; }
        public Filter? Filter { get; set; }
    }
}
