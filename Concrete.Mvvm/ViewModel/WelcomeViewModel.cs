using Concrete.UserPreferences;
using ReactiveUI;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Concrete.Mvvm.ViewModel;

public class WelcomeViewModel : ViewModelBase, IInit
{
#pragma warning disable CA1822 // Mark members as static
	public int MaxHeight => 900;
	public int MaxWidth => 900;
	public int MinHeight => 900;
	public int MinWidth => 900;
#pragma warning restore CA1822 // Mark members as static

	private readonly IRecentProjectReader _recentProjectReader;
	private readonly CancellationTokenSource _cancellationTokenSource = new();

	public WelcomeViewModel(IRecentProjectReader recentProjectReader)
	{
		_recentProjectReader = recentProjectReader;
	}

	public List<CreateOrLoadPositionViewModel> LoadItems { get; } = new()
	{
		new CreateOrLoadPositionViewModel("Some project", "Load", "last edited on: 21/2/2020")
	};

	public List<CreateOrLoadPositionViewModel> CreateItems { get; } = new()
	{
		new CreateOrLoadPositionViewModel("Course", "Create", "Some sort of long description that describes this object very acuratley")
	};

	public async Task Init()
	{
		var pointers = await _recentProjectReader.ReadRecentProjectsAsync(_cancellationTokenSource.Token);
		LoadItems.AddRange(pointers.Select(x => new CreateOrLoadPositionViewModel(x.ProjectName, "Load", "test")));
		this.RaisePropertyChanged(nameof(LoadItems));
	}
}
