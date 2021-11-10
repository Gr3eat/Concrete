using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Concrete.ViewModels;
using Concrete.Views;
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

		public override void Initialize()
		{
			AvaloniaXamlLoader.Load(this);
		}

		public override void OnFrameworkInitializationCompleted()
		{
			if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
			{

				desktop.MainWindow = new CourseEditView();
				{
					DataContext = _serviceProvider.GetRequiredService<ICourseEditViewModelFactory>().Create(null);
				};
			}

			base.OnFrameworkInitializationCompleted();
		}

		private static IServiceProvider InstallServices()
		{
			var services = new ServiceCollection();

			return services
				.WithEasyIoc(Assembly.GetExecutingAssembly())
				.BuildServiceProvider();
		}
	}

public class Installer : IInstaller
{
	public void Install(IServiceCollection container)
	{
		container.AddTransient<ICourseEditViewModelFactory, CourseEditViewModelFactory>();
	}
}
