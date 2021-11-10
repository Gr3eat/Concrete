using Concrete.MoodleEditor.Data;

namespace Concrete.MoodleEditor;

public interface ICourseImportService
{
	Task<CourseEntity> ImportCourse(string resultingFilepath, Stream input, CancellationToken token);
}
