using Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MainRepository : BaseRepository , IMainRepository
    {
        public MainRepository(AppDbContext appDbContext) : base(appDbContext) { }
    }
}
