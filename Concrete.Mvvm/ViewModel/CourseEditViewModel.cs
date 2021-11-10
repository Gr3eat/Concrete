using Concrete.MoodleEditor.Data;
using AsyncAwaitBestPractices.MVVM;
using Concrete.Storage;
using System.Threading.Tasks;
using System;
using System.Threading;

namespace Concrete.Mvvm.ViewModel;


public class CourseEditViewModel : ViewModelBase, ICourseEditViewModel
{
	private readonly IStorage _storageLocation;

	public CourseEntity Entity { get; }

	public CourseEditViewModel(CourseEntity entity, IStorage storageLocation)
	{
		Entity = entity;
		_storageLocation = storageLocation;
		SaveCommand = new AsyncCommand(Save, CanSave);
	}

	private bool CanSave(object? arg)
	{
		throw new NotImplementedException();
	}

	private Task Save()
	{
		return _storageLocation.StoreAsync(Entity, CancellationToken.None);
	}

	public IAsyncCommand SaveCommand { get; }
}
