using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapter
{
    public class MernisServiceAdapter : IUserValidationService
    {
        public object Validate(Gamer gamer)
        {
            var kPSPublicSoapClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            KPSPublicSoapClient client = kPSPublicSoapClient;
            return client.TCNoDogrulaAsync(
                Convert.ToInt64(gamer.TcNo);
            gamer.FirstName.ToUpper();
            gamer.LastName.ToUpper();
            gamer.DateYear.Result.Body.TCNoDogrulaResult;
        }

        bool IUserValidationService.Validate(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}