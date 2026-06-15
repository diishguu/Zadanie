namespace Zadanie;

public partial class LogInPage : ContentPage
{
    int count = 0;

    Label counterLabel;
    public LogInPage()
    {

        var myScrollView = new ScrollView();

        var myStackLayout = new VerticalStackLayout();
        myScrollView.Content = myStackLayout;

        counterLabel = new Label
        {
            Text = "Количество кликов: 0",
            FontSize = 35,
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center,
            Margin = 35

        };
        myStackLayout.Children.Add(counterLabel);

        var myButton = new Button
        {
            Text = "Нажми меня",
            HorizontalOptions = LayoutOptions.Center,
        };
        myStackLayout.Children.Add(myButton);

        myButton.Clicked += OnCounterClicked;

        this.Content = myScrollView;

    }
    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        counterLabel.Text = $"Количество кликов: {count}";

        SemanticScreenReader.Announce(counterLabel.Text);
    }
}