using FluentValidation;

namespace FluentApiValidation
{
    public class TestModel
    {
        public int sayi { get; set; }
        public string yazi { get; set; }
    }

    public class TestModelValidator : AbstractValidator<TestModel>
    {
        public TestModelValidator()
        {
            RuleFor(x => x.yazi).NotEmpty()
                                   .NotNull().WithMessage("boş geçilemez");

            RuleFor(x => x.sayi).NotEmpty().Must(x => x > default(int)).WithMessage("sıfıdan büyük olmalı");
        }
    }
}
