using EasyIOC;
using Microsoft.Extensions.DependencyInjection;

namespace Concrete.MoodleEditor;

public class Installer : IInstaller
{
	public void Install(IServiceCollection container) => container.AddTransient<ICourseSerializer, CourseSerializer>();
}
