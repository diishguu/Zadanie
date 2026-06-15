using System.Threading.Tasks;

namespace Zadanie
{
    public partial class MainPage : ContentPage
    {

        private int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LogIn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(LogInPage));

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
      
            count +=5;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

        }
    }
}
