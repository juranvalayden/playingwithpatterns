using CustomerInterface;

namespace Validation
{
    public class ValidationLinker : IValidation<ICustomer>
    {
        private readonly IValidation<ICustomer> _nextValidator;

        public ValidationLinker(IValidation<ICustomer> nextValidator)
        {
            _nextValidator = nextValidator;
        }

        public virtual void Validate(ICustomer anyType)
        {
            _nextValidator.Validate(anyType);
        }
    }
}