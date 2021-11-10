namespace Concrete.MoodleEditor.Data;

public class CategoryEntity
{
	public List<CategoryEntity> ChildCategories { get; set; } = new();
	public List<IQuestionEntity> Questions { get; set; } = new();
}
