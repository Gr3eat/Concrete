using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Concrete.Mvvm.View;

public partial class CourseEditView : UserControl
{
	public CourseEditView()
	{
		InitializeComponent();
	}

	private void InitializeComponent()
	{
		AvaloniaXamlLoader.Load(this);
	}
}
