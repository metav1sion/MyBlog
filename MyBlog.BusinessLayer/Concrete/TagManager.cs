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
    public class TagManager : ITagService
    {
        private readonly ITagDal _tagDal;

        public TagManager(ITagDal tagDal)
        {
            _tagDal = tagDal;
        }

        public void TInsert(Tag entity)
        {
            _tagDal.Insert(entity);
        }

        public void TDelete(int id)
        {
            _tagDal.Delete(id);
        }

        public void TUpdate(Tag entity)
        {
            _tagDal.Update(entity);
        }

        public List<Tag> TGetListAll()
        {
            return _tagDal.GetListAll();
        }

        public Tag TGetById(int id)
        {
            return _tagDal.GetById(id);
        }
    }
}
