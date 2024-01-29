namespace NUnitProject;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class CategoryTypeAttribute : PropertyAttribute
{
    public CategoryTypeAttribute(CategoryType type) : base(type.ToString()) { }
}