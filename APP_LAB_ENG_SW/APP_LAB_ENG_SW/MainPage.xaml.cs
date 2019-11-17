using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using APP_LAB_ENG_SW.Views;

namespace APP_LAB_ENG_SW
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void ChamarTelaDeLogin(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Login();
        }
    }
}
