using FluentValidation;
using StringIds.Core.Models;
using StringIds.Users.Domain.Models;

namespace StringIds.Users.Domain.Validation
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {

        }
    }

    public class UserBatchValidator: AbstractValidator<Batch<User>>
    {
        public UserBatchValidator()
        {
            RuleForEach(x => x.Data).SetValidator(new UserValidator());
        }
    }
}
