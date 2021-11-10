using Concrete.MoodleEditor.Data;

namespace Concrete.MoodleEditor;

internal class CourseSerializer : ICourseSerializer
{
	public Task<CourseEntity> ReadAsync(Stream stream, CancellationToken cancellationToken) => throw new NotImplementedException();
	public Task WriteAsync(Stream stream, CourseEntity course, CancellationToken cancellationToken) => throw new NotImplementedException();
}
