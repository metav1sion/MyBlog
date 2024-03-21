using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.ValidationRules.CategoryValidation
{
    public class CreateCategoryValidation : AbstractValidator<Category>
    {
        public CreateCategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter veri girişi yapınız.");
            RuleFor(x => x.CategoryName).MaximumLength(30)
                .WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız.");
        }
    }
}
