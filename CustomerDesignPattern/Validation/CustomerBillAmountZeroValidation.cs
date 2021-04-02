using System;
using CustomerInterface;

namespace Validation
{
    public class CustomerBillAmountZeroValidation : ValidationLinker
    {
        public CustomerBillAmountZeroValidation(IValidation<ICustomer> nextValidator) : base(nextValidator)
        {
        }

        public override void Validate(ICustomer anyType)
        {
            base.Validate(anyType);
            if (anyType.BillAmount != 0)
            {
                throw new Exception("Bill amount error");
            }
        }
    }
}
