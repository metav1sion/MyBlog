using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.BusinessLayer.ValidationRules.ArticleValidation
{
    public class CreateArticleValidation : AbstractValidator<Article>
    {
        public CreateArticleValidation()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Başlığı boş geçmeyiniz.").MinimumLength(5)
                .WithMessage("Lütfen en az 5 karakterlik bir veri girişi yapınız").MaximumLength(100)
                .WithMessage("Lütfen en fazla 100 karakter veri girişi yapınız.");

            RuleFor(x => x.Detail).NotEmpty().WithMessage("Boş geçmeyiniz.");
        }
    }
}
