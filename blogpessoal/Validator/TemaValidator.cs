using blogpessoal.Model;
using FluentValidation;

namespace blogpessoal.Validator
{
    public class TemaValidator : AbstractValidator<Tema>
    {
        public TemaValidator()
        {
            //Regras de validação

            RuleFor(t => t.Descricao)
                    .NotEmpty()
                    .MinimumLength(10)
                    .MaximumLength(255);
        }
    }
}
