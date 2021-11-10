using Concrete.MoodleEditor.Data;

namespace Concrete.ViewModels
{
	public class CourseEditViewModelFactory : ICourseEditViewModelFactory
	{
		public ICourseEditViewModel Create(CourseEntity? course)
		{
			return new CourseEditViewModel(course);
		}
	}
}
