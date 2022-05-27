using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {
        public IEnumerable<Article> GetArticlesByUserId(int userId);
        public IEnumerable<Article> GetAllIncludeUsers();
    }
}
