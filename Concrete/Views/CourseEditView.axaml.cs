using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Concrete.Views
{
	public partial class CourseEditView : Window
	{
		public CourseEditView()
		{
			InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
