using System.ComponentModel;

namespace Concrete.Mvvm.ViewModel;

public interface IPrimaryViewModel : INotifyPropertyChanged
{
	int MinWidth => 0;
	int MaxWidhth => int.MaxValue;
	int MinHeight => 0;
	int MaxHeight => int.MaxValue;
}
