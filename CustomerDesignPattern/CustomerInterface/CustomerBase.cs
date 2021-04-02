using System;
using System.ComponentModel.DataAnnotations;

namespace CustomerInterface
{
    public class CustomerBase : ICustomer
    {
        private readonly IValidation<ICustomer> _validation;
        private ICustomer _oldCopy;
        private IDiscount _discount;
        private IExtraCharge _extraCharge;

        [Key]
        public int Id { get; set; }
        public string CustomerType { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }
        
        public decimal ActualCost()
        {
            return BillAmount - _discount.Calculate(this) + _extraCharge.Calculate(this);
        }

        public CustomerBase()
        {
            CustomerName = "";
            CustomerType = "";
            PhoneNumber = "";
            BillAmount = 0;
            BillDate = DateTime.Now;
            Address = "";
        }

        public CustomerBase(IValidation<ICustomer> validation, IDiscount discount, IExtraCharge extraCharge)
        {
            _validation = validation;
            _discount = discount;
            _extraCharge = extraCharge;
        }

        public virtual void Validate()
        {
            _validation.Validate(this);
        }

        public void Clone()
        {
            _oldCopy = (ICustomer) MemberwiseClone();
        }

        public void Revert()
        {
            CustomerName = _oldCopy.CustomerName;
            CustomerType = _oldCopy.CustomerType;
            PhoneNumber = _oldCopy.PhoneNumber;
            BillAmount = _oldCopy.BillAmount;
            BillDate = _oldCopy.BillDate;
            Address = _oldCopy.Address;
        }
    }
}