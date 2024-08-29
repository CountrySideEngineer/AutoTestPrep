using AutoTestPrep.Command;
using CustomUserControls.Command;
using CustomUserControls.ViewModel;
using Logger;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DelegateCommand = AutoTestPrep.Command.DelegateCommand;

namespace AutoTestPrep.ViewModel
{
	internal class MainWindowViewModel : ViewModelBase
	{
		public string Title
		{
			get => Properties.Resources.IDS_APP_TITLE;
		}

		protected IEnumerable<TreeNodeBaseViewModel> _treeNodeItems = null;

		public IEnumerable<TreeNodeBaseViewModel> TreeNodeItems
		{
			get => _treeNodeItems;
			set
			{
				_treeNodeItems = value;
				RaisePropertyChanged();
				RaisePropertyChanged(nameof(IsProjectSet));
			}
		}

		/// <summary>
		/// Project set or not.
		/// </summary>
		public bool IsProjectSet
		{
			get
			{
				return TreeNodeItems != null;
			}
		}

		protected CommandGridExpanderViewModel? _selectedItem = null;
		public CommandGridExpanderViewModel? SelectedItem
		{
			get => _selectedItem;
			set
			{
				_selectedItem = value;
				RaisePropertyChanged();
			}
		}

		protected Command.DelegateCommand<TreeNodeBaseViewModel>? _selectedItemChangedCommand = null;
		public Command.DelegateCommand<TreeNodeBaseViewModel> SelectedItemChangedCommand
		{
			get
			{
				if (null == _selectedItemChangedCommand)
				{
					_selectedItemChangedCommand = new Command.DelegateCommand<TreeNodeBaseViewModel>(SelectedItemChangedExecute);
				}
				return _selectedItemChangedCommand;
			}
		}

		protected IEnumerable<CommandGridExpanderViewModel>? _selectedNodeItems = null;
		public IEnumerable<CommandGridExpanderViewModel>? SelectedNodeItems
		{
			get => _selectedNodeItems;
			set
			{
				_selectedNodeItems = value;
				RaisePropertyChanged();
			}
		}

		protected DelegateCommand? _testParseCommand = null;
		public DelegateCommand TestParseCommand
		{
			get
			{
				if (null == _testParseCommand)
				{
					_testParseCommand = new DelegateCommand(ReadTestCommandExecute);
				}
				return _testParseCommand;
			}
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MainWindowViewModel() : base()
		{
			TreeNodeItems = new List<TreeNodeBaseViewModel>()
			{
				new SolutionTreeNodeViewModel()
				{
					Title = "TestSolution",
					SubNodes = new List<TreeNodeBaseViewModel>()
					{
						new ProjectTreeNodeViewModel()
						{
							Title = "TestProjectName_001",
							TestProjectConfig = new TestProjectConfigInputViewModel(),
							SubNodes = new List<TreeNodeBaseViewModel>()
							{
								new FunctionTreeNodeViewModel()
								{
									Title = "FunctionName_001_001",
									FunctionInformation = new TestDriverCodeViewModel()
									{
										TestCode =
											"Sample code" + Environment.NewLine +
											"\tTab intend Line" + Environment.NewLine +
											"Sample function 001 - 001"
									}
								},
								new FunctionTreeNodeViewModel()
								{
									Title = "FunctionName_001_002",
									FunctionInformation = new TestDriverCodeViewModel()
									{
										TestCode =
											"Sample code" + Environment.NewLine +
											"\tTab intend Line" + Environment.NewLine +
											"Sample function 001 - 002" 
									}
								},
								new FunctionTreeNodeViewModel()
								{
									Title = "FunctionName_001_003",
									FunctionInformation = new TestDriverCodeViewModel()
									{
										TestCode =
											"Sample code" + Environment.NewLine +
											"\tTab intend Line" + Environment.NewLine +
											"\tTab intend Line" + Environment.NewLine +
											"Sample function 001 - 003"
									}
								}
							}
						}
					}
				}
			};
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="selectedItem"></param>
		public void SelectedItemChangedExecute(TreeNodeBaseViewModel selectedItem)
		{
			Log.TRACE();

			if (selectedItem is ProjectTreeNodeViewModel)
			{
				Log.DEBUG($"{nameof(selectedItem)} data type is {nameof(ProjectTreeNodeViewModel)}");

				ProjectTreeNodeViewModel projectNode = selectedItem as ProjectTreeNodeViewModel;
				CommandGridExpanderViewModel? testInformation = projectNode.TestProjectConfig;
				SelectedItem = testInformation ?? SelectedItem;

				Log.DEBUG((null == testInformation) ? "testInformation = null" : "testInformation != null");
			}
			else if (selectedItem is FunctionTreeNodeViewModel)
			{
				Log.DEBUG($"{nameof(selectedItem)} data type is {nameof(FunctionTreeNodeViewModel)}");

				FunctionTreeNodeViewModel functioNode = selectedItem as FunctionTreeNodeViewModel;
				CommandGridExpanderViewModel? testInformation = functioNode.FunctionInformation;
				SelectedItem = testInformation ?? SelectedItem;
			}
			else
			{
				Log.DEBUG($"{nameof(selectedItem)} data type is not {nameof(ProjectTreeNodeViewModel)}");
			}
		}

		protected virtual void ReadTestCommandExecute()
		{
			Log.TRACE();

			IEnumerable<TreeNodeBaseViewModel> testNodes = TreeNodeItems.ElementAt(0).SubNodes;
			var command = new ExecReadTestCommand();
			command.Execute(testNodes);
		}
	}
}
