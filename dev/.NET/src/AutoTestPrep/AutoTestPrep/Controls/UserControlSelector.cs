using AutoTestPrep.View;
using CustomUserControls.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AutoTestPrep.Controls
{
	internal class UserControlSelector : DataTemplateSelector
	{
		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
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
