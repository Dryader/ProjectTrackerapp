namespace ProjectTrackerApp.BusinessLogic;

internal class Project
{
    private readonly float _actualCost;
    private readonly string _title;
    private DateTime _dueDate;


    //TODO: Follow the instructions in the print document to complete the class definition
    private ProjectCategory _projectCategory;
    internal int _projectId;

    public Project(int projectId, string title, DateTime dueDate, float plannedCost, float actualCost,
        ProjectCategory projectCategory)
    {
        _projectId = projectId;
        _title = title;
        _dueDate = DueDate;
        PlannedCost = plannedCost;
        _actualCost = actualCost;
        _projectCategory = projectCategory;
    }

    public float PlannedCost { get; }

    public DateTime DueDate
    {
        get => _dueDate;
        set
        {
            if (_dueDate < DateTime.Today)
                throw new Exception("Due date is before the current date");
            _dueDate = value;
        }
    }

    public float CostDeviation => _actualCost - PlannedCost;


    public override string ToString()
    {
        return $"{_projectId}, {_title}, {PlannedCost}, {_actualCost}";
    }
}