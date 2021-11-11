using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Concrete.Mvvm.ViewModel;
using System.ComponentModel;

namespace Concrete.Mvvm.View;

public partial class MainWindow : Window
{
	private IPrimaryViewModel? _viewModel;

	public MainWindow()
	{
		DataContext = new DummyVm();
		InitializeComponent();
#if DEBUG
		this.AttachDevTools();
#endif
	}

	public IPrimaryViewModel? ViewModel
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
		private IPrimaryViewModel? _viewModel;

		public DummyVm()
		{
		}

		public IPrimaryViewModel VM
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
