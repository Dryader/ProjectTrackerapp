
namespace ProjectTrackerApp.BusinessLogic
{
    class Project
    {
        internal int _projectId;
        private string _title;
        private DateTime _dueDate;
        private float _plannedCost;
        private float _actualCost;


        //TODO: Follow the instructions in the print document to complete the class definition
        private ProjectCategory _projectCategory;
        public float PlannedCost => _plannedCost;

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
        
        public float CostDeviation => _actualCost - _plannedCost;
        public Project(int projectId, string title, DateTime dueDate, float plannedCost, float actualCost, ProjectCategory projectCategory)
        {
            _projectId = projectId;
            _title = title;
            _dueDate = DueDate;
            _plannedCost = plannedCost;
            _actualCost = actualCost;
            _projectCategory = projectCategory;
        }


        public override string ToString()
        {
            return $"{_projectId}, {_title}, {_plannedCost}, {_actualCost}";
        }
    }
    
}