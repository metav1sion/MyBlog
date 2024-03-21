using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.BusinessLayer.Abstract;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void TInsert(Article entity)
        {
            _articleDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _articleDal.Delete(id);
        }

        public void TUpdate(Article entity)
        {
            _articleDal.Update(entity);
        }

        public List<Article> TGetListAll()
        {
            return _articleDal.GetListAll();
        }

        public Article TGetById(int id)
        {
            return _articleDal.GetById(id);
        }
    }
}
