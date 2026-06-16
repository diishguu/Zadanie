
using Microsoft.Maui;
using System.Threading.Tasks;

namespace Zadanie
{
    public partial class MainPage : ContentPage
    {
        private Color colorNavy = Colors.Navy;
        private Color colorSilver = Colors.Silver;

        public MainPage()
        {
            InitializeComponent();
        }
        void OnLight(object sender, EventArgs e)
        {
            LayoutRoot.BackgroundColor = colorSilver;

            tipLabel.TextColor = colorNavy;
          
            totalLabel.TextColor = colorNavy;
           
        }

        void OnDark(object sender, EventArgs e)
        {
            LayoutRoot.BackgroundColor = colorNavy;

            tipLabel.TextColor = colorSilver;
       
            totalLabel.TextColor = colorSilver;
     
        }

    }
}
 
