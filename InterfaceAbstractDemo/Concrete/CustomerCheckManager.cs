using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPersonAsync(Customer customer)
        {          
            return true;
        }
    }
}
