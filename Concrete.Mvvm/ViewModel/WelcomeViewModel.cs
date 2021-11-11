using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concrete.Mvvm.ViewModel;

public class WelcomeViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
	public int MaxHeight => 700;
	public int MaxWidth => 700;
	public int MinHeight => 700;
	public int MinWidth => 700;
#pragma warning restore CA1822 // Mark members as static
}
