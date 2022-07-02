
using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
            public WriterValidator()
            {
                RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad kısmını boş geçemezsin boş geçemezsin");
                RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("soyad kısmını boş geçemezsin");
                RuleFor(x => x.WriterMail).MinimumLength(3).WithMessage("en az 3 karakter girebilirsiniz");
               
            }
        
    }
}
