using Concrete.MoodleEditor.Data;

namespace Concrete.ViewModels
{
	public interface ICourseEditViewModelFactory
	{
		ICourseEditViewModel Create(CourseEntity? course);
	}
}
