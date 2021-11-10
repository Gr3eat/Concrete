using Concrete.MoodleEditor.Data;
using Concrete.Storage;

namespace Concrete.Mvvm.ViewModel;

public class CourseEditViewModelFactory : ICourseEditViewModelFactory
{
	private readonly IStorage _storageService;

	public CourseEditViewModelFactory(IStorage storageService)
	{
		_storageService = storageService;
	}

	public ICourseEditViewModel Create(CourseEntity course) => new CourseEditViewModel(course, _storageService);
}
