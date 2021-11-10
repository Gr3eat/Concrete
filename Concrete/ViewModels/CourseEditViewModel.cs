using Concrete.Mvvm.ViewModel;
using Concrete.MoodleEditor.Data;

namespace Concrete.ViewModels
{


	public class CourseEditViewModel : ViewModelBase, ICourseEditViewModel
	{
		public CourseEntity? Entity { get; }

		public CourseEditViewModel(CourseEntity? entity)
		{
			Entity = entity;
		}
	}
}
