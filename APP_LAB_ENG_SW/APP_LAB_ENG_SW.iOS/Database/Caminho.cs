using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using APP_LAB_ENG_SW.Database;
using APP_LAB_ENG_SW.iOS.Database;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly:Dependency(typeof(Caminho))]
namespace APP_LAB_ENG_SW.iOS.Database
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string nomeBD)
        {
            string caminhoPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);//Caminho da pasta aonde será salvo o BD SQLite no ambiente iOS
            string caminhoLibrary = Path.Combine(caminhoPasta, "..", "Library");//No iOS devemos voltar um nível do caminho da pasta e acessar uma pasta chamada Library para salvar o BD SQLite

            string caminhoBD = Path.Combine(caminhoLibrary, nomeBD);//Combinar o caminho da pasta Library com o nome do banco

            return caminhoBD;
        
        }
    }
}