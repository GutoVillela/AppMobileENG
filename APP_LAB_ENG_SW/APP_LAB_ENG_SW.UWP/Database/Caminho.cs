using APP_LAB_ENG_SW.Database;
using APP_LAB_ENG_SW.UWP.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using Windows.Storage;

[assembly:Dependency(typeof(Caminho))]
namespace APP_LAB_ENG_SW.UWP.Database
{
    class Caminho : ICaminho
    {
        public string ObterCaminho(string nomeBD)
        {
            string caminhoPasta = ApplicationData.Current.LocalFolder.Path;//No Windows posso recuperar a pasta dos dados da aplicação pelo ApplicationData
            string caminhoBD = Path.Combine(caminhoPasta, nomeBD);//Combinar o caminho da pasta com o nome do BD

            return caminhoBD;
        }
    }
}
