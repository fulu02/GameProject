using System;

namespace GameProject.Adapter
{
    internal class KPSPublicSoapClient
    {
        private object kPSPublicSoap;

        public KPSPublicSoapClient(object kPSPublicSoap)
        {
            this.kPSPublicSoap = kPSPublicSoap;
        }

        public static object EndpointConfiguration { get; internal set; }

        internal object TCKimlikNoDogrulaAsync(long v1, string v2, string v3, object year)
        {
            throw new NotImplementedException();
        }

        internal object TCNoDogrulaAsync(long v1, string v2, string v3, object dateYear)
        {
            throw new NotImplementedException();
        }

        internal object TCKimlikNoDogrulaAsync(long v1, string v2, string v3, object dateYear)
        {
            throw new NotImplementedException();
        }
    }
}