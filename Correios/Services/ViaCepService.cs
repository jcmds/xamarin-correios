using System.Net;
using Correios.Models;
using Newtonsoft.Json;

namespace Correios.Services
{
    public static class ViaCepService
    {
        static readonly string _url = "http://viacep.com.br/ws/{0}/json/";

        public  static Address  GetAddress(string zipCode){

            var wc = new WebClient();
            var url = string.Format(_url,zipCode);
            var content =  wc.DownloadString(url);

            return JsonConvert.DeserializeObject<Address>(content);
        }
    }
}
