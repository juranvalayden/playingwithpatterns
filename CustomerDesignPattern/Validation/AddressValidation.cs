using System;
using CustomerInterface;

namespace Validation
{
    public class AddressValidation : ValidationLinker
    {
        public AddressValidation(IValidation<ICustomer> nextValidator) : base(nextValidator)
        {
        }

        public override void Validate(ICustomer anyType)
        {
            base.Validate(anyType);
            if (string.IsNullOrWhiteSpace(anyType.Address))
            {
                throw new Exception("Address is required");
            }
        }
    }
}