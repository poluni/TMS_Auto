namespace TestRailCore.Models;

public class Project
{
    public string ProjectName { get; set; }
    public string Announcement { get; set; }
    public bool? IsShowAnnouncement { get; set; }
    public int ProjectType { get; set; }
    public bool IsTestCaseApprovals { get; set; }

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