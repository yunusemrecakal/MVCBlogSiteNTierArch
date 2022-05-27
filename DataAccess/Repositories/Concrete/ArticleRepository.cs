using Core.Entities;
using DataAccess.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        private readonly ApplicationDBContext db;

        public ArticleRepository(ApplicationDBContext db):base(db)
        {
            this.db = db;
        }

        public IEnumerable<Article> GetArticlesByUserId(int userId)
        {
            return db.Articles.Where(a => a.UserId == userId).ToList();
        }

        IEnumerable<Article> IArticleRepository.GetAllIncludeUsers()
        {
            return db.Articles.Include(a => a.User).Include(b => b.Topics);
        }
    }
}
