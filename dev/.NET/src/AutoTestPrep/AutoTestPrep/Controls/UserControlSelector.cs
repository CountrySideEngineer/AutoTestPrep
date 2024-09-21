using CustomUserControls.ViewModel;
using System.Windows;
using System.Windows.Controls;
using Logger;
using AutoTestPrep.ViewModel;
using AutoTestPrep.View;

namespace AutoTestPrep.Controls
{
	internal class UserControlSelector : DataTemplateSelector
	{
		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			Log.TRACE();

			var viewModel = (CommandGridExpanderViewModel)item;
			var element = (FrameworkElement)container;

			Log.DEBUG((null == viewModel) ? "viewModel == null" : "viewModel != null");
			Log.DEBUG((null == element) ? "element == null" : "element != null");

			if ((null == viewModel) || (null == element))
			{
				return base.SelectTemplate(item, container);
			}
			else
			{
				string resourceName = string.Empty;
				if (item is TestProjectConfigInputViewModel)
				{
					Log.DEBUG($"{nameof(item)} is {nameof(TestProjectConfigInputViewModel)}");

					resourceName = "ItemSelect_001";
				}
				else if (item is TestDriverCodeViewModel)
				{
					Log.DEBUG($"{nameof(item)} is {nameof(TestDriverCodeViewModel)}");

					resourceName = "ItemSelect_002";
				}
				else
				{
					Log.DEBUG($"{nameof(item)} is unknown.");

					resourceName = "ItemSelect_001";
				}

				Log.DEBUG($"{nameof(resourceName),16} = {resourceName}");

				DataTemplate template = (DataTemplate)element.FindResource(resourceName);
				UserControl userControl = (UserControl)template.LoadContent();
				userControl.DataContext = viewModel;

				return template;
			}
		}
	}
}
