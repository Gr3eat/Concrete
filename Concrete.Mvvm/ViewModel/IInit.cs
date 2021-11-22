using System.Threading;
using System.Threading.Tasks;

namespace Concrete.Mvvm.ViewModel;

public interface IInit
{
	Task Init();
}
