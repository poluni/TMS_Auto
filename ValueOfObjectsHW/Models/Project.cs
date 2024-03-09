namespace ValueOfObjectsHW.Models;

public class Project
{
    public string ProjectName { set; get; }
    public string Announcement { set; get; }
    public int ProjectType { set; get; }

    public Project() { }

    public Project GenerateProject()
    {
        Project newProject = new Project()
        {
            ProjectName = "Test Project" + new Random().Next().ToString(),
            Announcement = "Test Details" + new Random().Next().ToString(),
            ProjectType = new Random().Next(0, 3)
        };
        return newProject;
    }
}