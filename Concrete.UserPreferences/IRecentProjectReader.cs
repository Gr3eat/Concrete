using Concrete.ProjectStructure;

namespace Concrete.UserPreferences;

public interface IRecentProjectReader
{
	Task<IEnumerable<ProjectPointer>> ReadRecentProjectsAsync(CancellationToken cancellationToken);
	Task PersistProjectOpened(ProjectPointer projectPointer, DateTime wheneOpened, CancellationToken cancellationToken);
}
