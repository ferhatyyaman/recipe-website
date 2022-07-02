using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("kategori adını boş geçemezsin");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsin");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("en az 3 karakter girebilirsiniz");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("max 20 karakter girebilirsiniz");
        }
    }
}
