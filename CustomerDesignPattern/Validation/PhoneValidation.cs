using System;
using CustomerInterface;

namespace Validation
{
    public class PhoneValidation : ValidationLinker
    {
        public PhoneValidation(IValidation<ICustomer> nextValidator) : base(nextValidator)
        {

        }

        public override void Validate(ICustomer anyType)
        {
            base.Validate(anyType);

            if (string.IsNullOrWhiteSpace(anyType.PhoneNumber))
            {
                throw new Exception("Phone number is required");
            }
        }
    }
}