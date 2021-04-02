using System;
using CustomerInterface;

namespace ExtraCharge
{
    public class ExtraChargesWeekend : IExtraCharge
    {
        public decimal Calculate(ICustomer customer)
        {
            if (customer.BillDate.DayOfWeek == DayOfWeek.Saturday || customer.BillDate.DayOfWeek == DayOfWeek.Sunday)
            {
                return customer.BillAmount * 0.01m;
            }

            return 0;
        }
    }
}
