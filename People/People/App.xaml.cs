using People.Models;

namespace People;

public partial class App : Application
{
	public static PersonRepository PersonRepo { get; private set; }

	public App()
	{
        InitializeComponent();
		string dbPath = Path.Combine(
			FileSystem.AppDataDirectory,
			"people.db3");

		PersonRepo = PersonRepo;
    }

	protected override Window CreateWindow(IActivationState activationState)
	{
		return new Window(new AppShell());
	}
}