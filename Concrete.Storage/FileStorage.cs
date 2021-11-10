using Concrete.MoodleEditor;
using Concrete.MoodleEditor.Data;
using EasyIOC;
using Microsoft.Extensions.DependencyInjection;

namespace Concrete.Storage;

internal class FileStorage : IStorage
{
	private readonly ICourseSerializer _courseReader;

	public FileStorage(ICourseSerializer courseReader)
	{
		_courseReader = courseReader;
	}

	public async Task StoreAsync(CourseEntity entity, CancellationToken cancellation)
	{
		using var file = File.Open(entity.Path, FileMode.OpenOrCreate);
		await _courseReader.WriteAsync(file, entity, cancellation);
	}
}

public class Installer : IInstaller
{
	public void Install(IServiceCollection container) => container.AddTransient<IStorage, FileStorage>();
}
