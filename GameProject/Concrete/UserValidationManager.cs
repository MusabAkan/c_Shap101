using EDevletServiceReference;
using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
    

        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);

            var result = client.TCKimlikNoDogrulaAsync(gamer.IdentityNumber,
                                                 gamer.FirstName.ToUpper(),
                                                 gamer.LastName.ToUpper(),
                                                 gamer.BirthYear).
                                                 GetAwaiter().
                                                 GetResult().
                                                 Body.
                                                 TCKimlikNoDogrulaResult;

            return result;
        }
    }
}
