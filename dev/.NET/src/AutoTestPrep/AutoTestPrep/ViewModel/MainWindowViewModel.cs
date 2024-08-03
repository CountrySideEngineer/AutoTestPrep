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
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
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

		protected IEnumerable<ProjectItemViewModel>? _projectRootItem = null;

		public IEnumerable<ProjectItemViewModel>? ProjectRootItem
		{
			get => _projectRootItem;
			set
			{
				_projectRootItem = value;
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
				return ProjectRootItem != null;
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

		protected Command.DelegateCommand<ProjectItemViewModel>? _selectedItemChangedCommand = null;
		public Command.DelegateCommand<ProjectItemViewModel> SelectedItemChangedCommand
		{
			get
			{
				if (null == _selectedItemChangedCommand)
				{
					_selectedItemChangedCommand = new Command.DelegateCommand<ProjectItemViewModel>(SelectedItemChangedExecute);
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
					_testParseCommand = new DelegateCommand(TestParseCommandExecute);
				}
				return _testParseCommand;
			}
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MainWindowViewModel() : base()
		{
			//ProjectRootItem = null;
			ProjectRootItem = new List<ProjectItemViewModel>()
			{
				new ProjectItemViewModel()
				{
					Name = "Solution Name (Tree root)",
					SubProjects = new List<ProjectItemViewModel>()
					{
						new ProjectItemViewModel()
						{
							Name = "TestProjectName_001",
							TestInformation = new TestProjectConfigInputViewModel(),
							SubProjects = new List<ProjectItemViewModel>()
							{
								new ProjectItemViewModel()
								{
									Name = "FunctionName_001",
									SubProjects = new List<ProjectItemViewModel>()
									{
										new ProjectItemViewModel()
										{
											Name = "FunctionName_001_TestCase_001"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_001_TestCase_002"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_001_TestCase_003"
										},
									}
								},
								new ProjectItemViewModel()
								{
									Name = "FunctionName_002",
									SubProjects = new List<ProjectItemViewModel>()
									{
										new ProjectItemViewModel()
										{
											Name = "FunctionName_002_TestCase_001"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_002_TestCase_002"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_002_TestCase_003"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_002_TestCase_004"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_002_TestCase_005"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_002_TestCase_006"
										},
									}
								},
								new ProjectItemViewModel()
								{
									Name = "FunctionName_003",
									SubProjects = new List<ProjectItemViewModel>()
									{
										new ProjectItemViewModel()
										{
											Name = "FunctionName_003_TestCase_001"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_003_TestCase_002"
										},
									}
								},
							}
						},
						new ProjectItemViewModel()
						{
							Name = "TestProjectName_002",
							TestInformation = new TestProjectConfigInputViewModel(),
							SubProjects = new List<ProjectItemViewModel>()
							{
								new ProjectItemViewModel()
								{
									Name = "FunctionName_101",
									SubProjects = new List<ProjectItemViewModel>()
									{
										new ProjectItemViewModel()
										{
											Name = "FunctionName_101_TestCase_001"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_101_TestCase_002"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_101_TestCase_003"
										},
									}
								},
								new ProjectItemViewModel()
								{
									Name = "FunctionName_102",
									SubProjects = new List<ProjectItemViewModel>()
									{
										new ProjectItemViewModel()
										{
											Name = "FunctionName_102_TestCase_001"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_102_TestCase_002"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_102_TestCase_003"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_102_TestCase_004"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_102_TestCase_005"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_102_TestCase_006"
										},
									}
								},
								new ProjectItemViewModel()
								{
									Name = "FunctionName_103",
									SubProjects = new List<ProjectItemViewModel>()
									{
										new ProjectItemViewModel()
										{
											Name = "FunctionName_103_TestCase_001"
										},
										new ProjectItemViewModel()
										{
											Name = "FunctionName_103_TestCase_002"
										},
									}
								},
							}
						}                   }
				}
			};
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="selectedItem"></param>
		public void SelectedItemChangedExecute(ProjectItemViewModel selectedItem)
		{
			Log.TRACE();

			CommandGridExpanderViewModel? testInformation = selectedItem.TestInformation;
			SelectedItem = (null == testInformation) ? SelectedItem : testInformation;

			Log.DEBUG((null == testInformation) ? "testInformation = null" : "testInformation != null");
		}

		protected virtual void TestParseCommandExecute()
		{
			Log.TRACE();

			var command = new ExecTestParseCommand();
			command.Execute(null);
		}
	}
}
