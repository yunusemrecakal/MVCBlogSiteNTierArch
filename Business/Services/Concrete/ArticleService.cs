using Business.Services.Abstract;
using Business.Services.Concrete;
using Core.Entities;
using DataAccess.Repositories;
using DataAccess.Repositories.Abstract;
using DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ArticleService : GenericService<Article>, IArticleService
    {
        private readonly IArticleRepository articleRepository;

        public ArticleService(IArticleRepository articleRepository) : base (articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        public IEnumerable<Article> GetAllIncludeUsers()
        {
            return articleRepository.GetAllIncludeUsers();
        }

        public IEnumerable<Article> GetArticlesByUserId(int userId)
        {
            if (userId >= 0)
            {
                return articleRepository.GetArticlesByUserId(userId);
            }
            else throw new Exception();
        }
    }
}