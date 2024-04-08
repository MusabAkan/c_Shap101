using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Concrete
{
    public class TurkCafeCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public TurkCafeCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPersonAsync(customer))
                base.Save(customer);
            else
                throw new Exception("Not a valid person");
        }
    }
}
