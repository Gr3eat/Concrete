using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Concrete.Mvvm.ViewModel;
using System.ComponentModel;

namespace Concrete.Mvvm.View;

public partial class MainWindow : Window
{
	private IViewModel? _viewModel;

	public MainWindow()
	{
		DataContext = new DummyVm();
		InitializeComponent();
#if DEBUG
		this.AttachDevTools();
#endif
	}

	public IViewModel? ViewModel
	{
		get => _viewModel;
		set
		{
			_viewModel = value;
			((DummyVm)DataContext!).VM = value!;
		}
	}

	private void InitializeComponent()
	{
		AvaloniaXamlLoader.Load(this);
	}

	internal class DummyVm : INotifyPropertyChanged
	{
		private IViewModel? _viewModel;

		public DummyVm()
		{
		}

		public IViewModel VM
		{
			get => _viewModel!;
			set
			{
				_viewModel = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(VM)));

			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;
	}

}
