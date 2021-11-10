using Concrete.MoodleEditor.Data;

namespace Concrete.Mvvm.ViewModel;

public interface ICourseEditViewModelFactory
{
	ICourseEditViewModel Create(CourseEntity course);
}
