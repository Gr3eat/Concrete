using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Concrete.Mvvm.ViewModel;

namespace Concrete.Mvvm.View;

public partial class MainWindow : Window
{
	private IViewModel? _viewModel;

	public MainWindow()
	{
		DataContext = this;
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
			Content = value;
		}
	}

	private void InitializeComponent()
	{
		AvaloniaXamlLoader.Load(this);
	}
}
