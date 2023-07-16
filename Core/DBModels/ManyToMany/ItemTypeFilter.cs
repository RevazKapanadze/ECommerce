using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DBModels.ManyToMany
{
    public class ItemTypeFilter
    {
        public Guid Id { get; set; }
        public Guid ItemTypeId { get; set; }
        public ItemType? ItemType { get; set; }
        public Guid FilterId { get; set; }
        public Filter? Filter { get; set; }
    }
}
