using Concrete.MoodleEditor.Data;

namespace Concrete.Storage;
public interface IStorage
{
	Task StoreAsync(CourseEntity entity, CancellationToken cancellation);
}
