using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Concrete.Mvvm.View;
using Concrete.Mvvm.ViewModel;
using EasyIOC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace Concrete;
public class App : Application
{
	private readonly IServiceProvider _serviceProvider;
	public App()
	{
		_serviceProvider = InstallServices();
	}

	public override void Initialize() => AvaloniaXamlLoader.Load(this);

	public override void OnFrameworkInitializationCompleted()
	{
		if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
		{
			var entrypoint = _serviceProvider.GetRequiredService<IEntryPoint>();
			var window = entrypoint.Start(desktop.Args);
			if (window is not null)
				desktop.MainWindow = window;
			else
				desktop.Shutdown(0);

		}

		base.OnFrameworkInitializationCompleted();
	}

	private static IServiceProvider InstallServices()
	{
		var services = new ServiceCollection();
		services.AddTransient<IEntryPoint, EntryPoint>();
		return services
			.WithEasyIoc(Assembly.GetExecutingAssembly())
			.BuildServiceProvider();
	}
}
