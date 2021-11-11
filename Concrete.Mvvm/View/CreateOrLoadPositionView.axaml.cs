using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Concrete.Mvvm.View;

public partial class CreateOrLoadPositionView : UserControl
{
	public CreateOrLoadPositionView()
	{
		InitializeComponent();
	}

	private void InitializeComponent()
	{
		AvaloniaXamlLoader.Load(this);
	}
}
