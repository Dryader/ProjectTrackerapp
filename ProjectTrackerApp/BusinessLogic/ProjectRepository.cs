namespace ProjectTrackerApp.BusinessLogic;

internal class ProjectRepository
{
    //TODO: Follow the instructions in the print document to complete the class definition
    private List<Project> listOfProjects;


    public void AddProject(Project project)
    {
        // foreach (Project i in listOfProjects)
        // {
        //     foreach (var j in listOfProjects)
        //     {
        //         if (i._projectId == j._projectId)
        //         {
        //             throw new Exception("ID already matches a project in the list");
        //         }
        //     }
        //
        //     AddProject(project);
        // }
        for (var i = 0; i < listOfProjects.Count; i++)
        {
            if (project._projectId == listOfProjects[i]._projectId)
                throw new Exception("ID already matches a project in the list");

            AddProject(project);
        }
    }

    public float TotalCostDeviation()
    {
        float totalCost = 0;
        for (var i = 0; i < listOfProjects.Count; i++) totalCost = listOfProjects[i].CostDeviation + totalCost;

        return totalCost / listOfProjects.Count;
    }
    //public List<Project> ListOfProjects => listOfProjects;
}