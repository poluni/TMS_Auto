namespace NUnitProject;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class PriorityAttribute : PropertyAttribute
{
    private readonly int _priority;

    public PriorityAttribute(Priority type) : base(type.ToString()) { }

    public PriorityAttribute(int propertyValue) : base(propertyValue)
    {
        _priority = propertyValue;
    }
}