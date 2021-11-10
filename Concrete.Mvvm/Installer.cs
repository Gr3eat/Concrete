using Concrete.Mvvm.ViewModel;
using EasyIOC;
using Microsoft.Extensions.DependencyInjection;

namespace Concrete.Mvvm;

public class Installer : IInstaller
{
	public void Install(IServiceCollection container)
	{
		container.AddTransient<ICourseEditViewModelFactory, CourseEditViewModelFactory>();
	}
}
