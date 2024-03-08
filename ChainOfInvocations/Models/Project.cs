namespace ChainOfInvocationsHW.Models;

public class Project
{
    public string ID { set; get; } = new Random().Next().ToString();
    public string ProjectName { set; get; }
    public string Announcement { set; get; }
    public int ProjectType { set; get; }
    public DateTime CreateDate { set; get; }

    public Project() { }

    public Project GenerateProject()
    {
        Project newProject = new Project()
        {
            ProjectName = "Test Project" + new Random().Next().ToString(),
            Announcement = "Test Details" + new Random().Next().ToString(),
            ProjectType = 1
        };
        return newProject;
    }
}