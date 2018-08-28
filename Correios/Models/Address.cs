using Newtonsoft.Json;

namespace Correios.Models
{
    public class Address
    {
        [JsonProperty("cep")]
        public string ZipCode
        {
            get;
            set;
        }

        [JsonProperty("localidade")]
        public string City
        {
            get;
            set;
        }

        [JsonProperty("bairro")]
        public string Neighborhood
        {
            get;
            set;
        }

        [JsonProperty("logradouro")]
        public string Place
        {
            get;
            set;
        }

        [JsonProperty("uf")]
        public string Country
        {
            get;
            set;
        }
    }
}
