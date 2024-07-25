using CustomUserControls.ViewModel;
using System.Windows;
using System.Windows.Controls;
using Logger;

namespace AutoTestPrep.Controls
{
	internal class UserControlSelector : DataTemplateSelector
	{
		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			Log.TRACE();

			var viewModel = (CommandGridExpanderViewModel)item;
			var element = (FrameworkElement)container;
			if ((null == viewModel) || (null == element))
			{
				return base.SelectTemplate(item, container);
			}
			else
			{
				DataTemplate template = (DataTemplate)element.FindResource("ItemSelect_001");
				UserControl userControl = (UserControl)template.LoadContent();
				userControl.DataContext = viewModel;

				return template;
			}

		}
	}
}
