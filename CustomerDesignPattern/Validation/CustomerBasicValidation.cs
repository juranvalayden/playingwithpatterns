using System;
using CustomerInterface;

namespace Validation
{
    public class CustomerNameValidation : IValidation<ICustomer>
    {
        public void Validate(ICustomer anyType)
        {
            if (string.IsNullOrWhiteSpace(anyType.CustomerName))
            {
                throw new Exception("Customer name is required");
            }
        }
    }
}