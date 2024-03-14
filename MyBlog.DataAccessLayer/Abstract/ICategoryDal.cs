﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
    }
}
