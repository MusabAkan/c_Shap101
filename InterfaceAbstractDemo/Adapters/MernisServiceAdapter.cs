using InterfaceAbstractDemo.Abstract;
using MernisServiceReference;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPersonAsync(Customer customer)
        {
            KPSPublicSoapClient client = new(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);

            return client.TCKimlikNoDogrulaAsync(long.Parse(customer.NationalityId),
                                                 customer.FirstName.ToUpper(),
                                                 customer.LastName,
                                                 customer.DateOfBirth.Year).
                                                 GetAwaiter().
                                                 GetResult().
                                                 Body.
                                                 TCKimlikNoDogrulaResult;

        }
    }
}
