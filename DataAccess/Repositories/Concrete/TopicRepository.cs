using Core.Entities;
using DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete
{
    public class TopicRepository : GenericRepository<Topic>, ITopicRepository
    {
        private readonly ApplicationDBContext db;

        public TopicRepository(ApplicationDBContext db):base(db)
        {
            this.db = db;
        }
    }
}
