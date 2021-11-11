using Avalonia.Controls;
using Concrete.Mvvm.View;
using Concrete.Mvvm.ViewModel;
using System;

namespace Concrete;

internal class EntryPoint : IEntryPoint
{
	private readonly ICourseEditViewModelFactory _courseEditViewModelFactory;

	public EntryPoint(ICourseEditViewModelFactory courseEditViewModelFactory)
	{
		_courseEditViewModelFactory = courseEditViewModelFactory;
	}

	public Window Start(string[] args) => new MainWindow()
	{
		ViewModel = new WelcomeViewModel()
	};
}
