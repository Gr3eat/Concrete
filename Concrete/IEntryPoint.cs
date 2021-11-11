using Avalonia.Controls;

namespace Concrete;

internal interface IEntryPoint
{
	Window? Start(string[] args);
}
