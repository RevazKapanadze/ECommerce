using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DBModels
{
    public class ItemMainCategory
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public Item? Item { get; set; }
        public Guid MainCategoryId { get; set; }
        public MainCategory? MainCategory { get; set; }
    }
}
