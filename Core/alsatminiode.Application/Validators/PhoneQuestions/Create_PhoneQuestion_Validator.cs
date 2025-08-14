using alsatminiode.Application.ViewModels.PhoneQuestions;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Application.Validators.PhoneQuestions
{
    public class Create_PhoneQuestion_Validator : AbstractValidator<VM_Create_PhoneQuestion>
    {
        public Create_PhoneQuestion_Validator()
        {
            RuleFor(q => q.QuestionText)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Soru alanını boş bırakmayınız.")
                .MaximumLength(255)
                .MinimumLength(10)
                    .WithMessage("Lütfen soru alanını minimum 10 maksimum 255 karakter olacak şekilde girin.");
        }
    }
}
