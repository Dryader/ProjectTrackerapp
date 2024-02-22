using ProjectTrackerApp.BusinessLogic;

namespace ProjectTrackerApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        new ProjectRepository();
    }
}