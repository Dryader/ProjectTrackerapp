using ProjectTrackerApp.BusinessLogic;

namespace ProjectTrackerApp;

public partial class MainPage : ContentPage
{
    private readonly ProjectRepository _repository = new();

    public MainPage()
    {
        InitializeComponent();
        //new ProjectRepository();
        //ProjectRepository _repository = new ProjectRepository();
    }

    public void AddButton_OnClicked(object sender, EventArgs e)
    {
        //_repository.AddProject(Project e);
        //ProjectsListView.
        SummaryLabel.Text = _repository.TotalCostDeviation().ToString();
        DisplayAlert("Success", "Project was added", "Ok");
    }
}