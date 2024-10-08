﻿using System;
using System.Windows;
using AutoTestPrep.Model.EventArgs;
using AutoTestPrep.View;
using AutoTestPrep.ViewModel;

namespace AutoTestPrep
{
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Data context changed event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Argument of event.</param>
		private void MainWindow_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			this.DataContext = e.NewValue;
			var viewModel = (NotificationViewModelBase)this.DataContext;
			viewModel.NotifyOkInformation += this.NotifyOkInformation;
			viewModel.NotifyErrorInformation += this.NotifyErrorInformation;
			try
			{
				((MainWindowsViewModel)viewModel).ShowAboutReq += this.ShowAboutEventHandler;
				((MainWindowsViewModel)viewModel).ShowPluginRegisterReq += this.ShowPluginRegisterEventHandler;
			}
			catch (InvalidCastException)
			{
				//If can not cast, ignore the exception.
			}
		}

		/// <summary>
		/// OK information notificatoin event handler
		/// </summary>
		/// <param name="sender">Event sender</param>
		/// <param name="args">Event argument</param>
		protected void NotifyOkInformation(object sender, NotificationEventArgs args)
		{
			MessageBox.Show(args.Message, args.Title, MessageBoxButton.OK, MessageBoxImage.None);
		}

		/// <summary>
		/// Error information notification event handler.
		/// </summary>
		/// <param name="sender">Event sender</param>
		/// <param name="args">Event argument</param>
		protected void NotifyErrorInformation(object sender, NotificationEventArgs args)
		{
			MessageBox.Show(args.Message, args.Title, MessageBoxButton.OK, MessageBoxImage.Error);
		}

		/// <summary>
		/// Show "about" window event handler.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">Event argument.</param>
		protected void ShowAboutEventHandler(object sender, EventArgs e)
		{
			var about = new HelpWindow()
			{
				Owner = this
			};
			about.ShowDialog();
		}

		protected void ShowPluginRegisterEventHandler(object sender, EventArgs e)
		{
			var registPlugin = new PluginRegisterWindow();
			registPlugin.Owner = this;
			registPlugin.ShowDialog();
		}
	}
}
