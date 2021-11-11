using System.ComponentModel;

namespace Concrete.Mvvm.ViewModel.WelcomeViewTemplates;

internal class CreateOrLoadPositionViewModel : INotifyPropertyChanged
{
	public string Name { get; } = "";

	public event PropertyChangedEventHandler? PropertyChanged;
}
