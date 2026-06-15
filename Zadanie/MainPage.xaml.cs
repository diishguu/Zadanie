using System.Threading.Tasks;

namespace Zadanie
{
    public partial class MainPage : ContentPage
    {
        string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
        public MainPage()
        {
            InitializeComponent();

            if (File.Exists(_fileName))
            {
                editor.Text = File.ReadAllText(_fileName);
            }

        }


    }
}
        /*
        Button loginButton;
        VerticalStackLayout layout;

        public MainPage()
        {
            this.BackgroundColor = Color.FromArgb("AFBCD2");

            layout = new VerticalStackLayout
            {
                Margin = new Thickness(15, 15, 15, 15),
                Padding = new Thickness(30, 60, 60, 60),
                Children =
            {
                new Label { Text = "Пожалуйста зарегестрируйтесь", FontSize = 60, TextColor = Color.FromArgb("637E9C") },
                new Label { Text = "Имя", TextColor = Color.FromArgb("1E1E1E") },
                new Entry (),
                new Label { Text = "Пароль", TextColor = Color.FromArgb("1E1E1E") },
                new Entry { IsPassword = true }
            }
            };

            loginButton = new Button { Text = "Редистрация", BackgroundColor = Color.FromArgb("526683"),
            Margin = new Thickness(20)};
            layout.Children.Add(loginButton);

            Content = layout;


        }*/
  


    /*
    private int count = 0;
    public MainPage()
    {
        InitializeComponent();
    }

    string? translatedNumber;
    private void OnTranslate(object sender, EventArgs e)
    {
        string enteredNumber = PhoneNumberText.Text;
        translatedNumber = PhonewordTranslator.ToNumber(enteredNumber);

        if (!string.IsNullOrEmpty(translatedNumber))
        {
            CallButton.IsEnabled = true;
            CallButton.Text = "Call " + translatedNumber;
        }
        else
        {
            CallButton.IsEnabled = false;
            CallButton.Text = "Call";
        }
    }



        async void OnCall(object sender, System.EventArgs e)
        {
            if (await this.DisplayAlertAsync(
                "Dial a Number",
                "Would you like to call " + translatedNumber + "?",
                "Yes",
                "No"))
            {
                try
                {
                    if (PhoneDialer.Default.IsSupported && !string.IsNullOrWhiteSpace(translatedNumber))
                        PhoneDialer.Default.Open(translatedNumber);
                }
                catch (ArgumentNullException)
                {
                    await DisplayAlertAsync("Unable to dial", "Phone number was not valid.", "OK");
                }
                catch (Exception)
                {
                    // Other error has occurred.
                    await DisplayAlertAsync("Unable to dial", "Phone dialing failed.", "OK");
                }
            }

        }
    */
    /*private async void LogIn_Clicked(object sender, EventArgs e)
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
    */

    
