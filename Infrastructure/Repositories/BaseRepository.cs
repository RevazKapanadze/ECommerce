using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BaseRepository
    {
        public AppDbContext Context { get; private set; }
        public BaseRepository(AppDbContext context)
        {
            this.Context = context;
        }

        public virtual void Dispose() { }
    }
}
