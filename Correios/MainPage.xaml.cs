using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correios.Services;
using Xamarin.Forms;

namespace Correios
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {

            btnSearch.Opacity = 0.25;
            btnSearch.IsEnabled = false;

            var zipCode = ZipCodeEntry.Text.Trim()
                                      .Replace("-",string.Empty);

            if(string.IsNullOrEmpty(zipCode))
            {
                AddressLabel.Text = "Cep inválido.";
                return;
            }

            var address = ViaCepService.GetAddress(zipCode);
            var sb = FormatarRetorno(address);

            AddressLabel.Text = sb.ToString();


            btnSearch.Opacity = 1;
            btnSearch.IsEnabled = true;
        
        }

        private static StringBuilder FormatarRetorno(Models.Address address)
        {
            var sb = new StringBuilder();

            sb.AppendLine("CEP: " + address.ZipCode);
            sb.AppendLine("Endereço: " + address.Place);
            sb.AppendLine("Bairro: " + address.Neighborhood);
            sb.AppendLine("Cidade: " + address.City);
            sb.AppendLine("UF: " + address.Country);

            return sb;
        }
    }
}
