using System.ComponentModel;

namespace Concrete.Mvvm.ViewModel;

public class CreateOrLoadPositionViewModel 
{
	public string Name { get; }
	public string Description { get; }
	public string ButtonDescription { get; }

	public CreateOrLoadPositionViewModel(string name, string buttonDescription, string description)
	{
		Name = name;
		ButtonDescription = buttonDescription;
		Description = description;
	}

}
