using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using APP_LAB_ENG_SW.Database;
using System.IO;
using APP_LAB_ENG_SW.Droid.Database;

[assembly:Dependency(typeof(Caminho))]
namespace APP_LAB_ENG_SW.Droid.Database
{
    class Caminho : ICaminho
    {
        public string ObterCaminho(string nomeBD)
        {
            string caminhoPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);//Caminho da pasta aonde será salvo o BD SQLite no ambiente Android
            string caminhoBD = Path.Combine(caminhoPasta, nomeBD);//Combinar o caminho da pasta com o nome do arquivo SQLite vindo por parâmetro

            return caminhoBD;
        }
    }
}