using System;
using CustomerInterface;

namespace Validation
{
    public class BillValidation :ValidationLinker
    {
        public BillValidation(IValidation<ICustomer> nextValidator) : base(nextValidator)
        {
        }

        public override void Validate(ICustomer anyType)
        {
            base.Validate(anyType);

            if (anyType.BillAmount == 0)
            {
                throw new Exception("Bill amount should be > 0");
            }

            if (anyType.BillDate > DateTime.Now)
            {
                throw new Exception("Bill date cannot be in the future");
            }
        }
    }
}