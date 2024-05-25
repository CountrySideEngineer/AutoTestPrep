using AutoTestPrep.Command;
using CustomUserControls.Command;
using CustomUserControls.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

		protected DelegateCommand<ProjectItemViewModel>? _selectedItemChangedCommand = null;
		public DelegateCommand<ProjectItemViewModel> SelectedItemChangedCommand
		{
			get
			{
				if (null == _selectedItemChangedCommand)
				{
					_selectedItemChangedCommand = new DelegateCommand<ProjectItemViewModel>(SelectedItemChangedExecute);
				}
				return _selectedItemChangedCommand;
			}
		}

		Dictionary<string, CommandGridExpanderViewModel>? _itemCommandDictionary = null;

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
					Name = "Root",
					SubProjects = new List<ProjectItemViewModel>()
					{
						new ProjectItemViewModel()
						{
							Name = "SubItem_001",
							SubProjects = new List<ProjectItemViewModel>()
							{
								new ProjectItemViewModel()
								{
									Name = "SubItem_001_001",
								},
								new ProjectItemViewModel()
								{
									Name = "SubItem_001_002",
								},
								new ProjectItemViewModel()
								{
									Name = "SubItem_001_003",
								},

							}
						}
					}
				}
			};

			_itemCommandDictionary = new Dictionary<string, CommandGridExpanderViewModel>()
			{
				{
					"SubItem_001_001", new CommandGridExpanderViewModel()
					{
						CategoryName = "SubItem_001_001",
						Items = new List<CommandGridExpanderItem>()
						{
							new CommandGridExpanderItem()
							{
								Title = "SubItem_001_001_Content_001"
							},
							new CommandGridExpanderItem()
							{
								Title = "SubItem_001_001_Content_002"
							},
							new CommandGridExpanderItem()
							{
								Title = "SubItem_001_001_Content_003"
							},
							new CommandGridExpanderItem()
							{
								Title = "SubItem_001_001_Content_004"
							},
						}
					}
				},
				{
					"SubItem_001_002", new CommandGridExpanderViewModel()
					{
						CategoryName = "SubItem_001_002",
						Items = new List<CommandGridExpanderItem>()
						{
							new CommandGridExpanderItem()
							{
								Title = "SubItem_001_002_Content_001"
							},
							new CommandGridExpanderItem()
							{
								Title = "SubItem_001_002_Content_002"
							},
							new CommandGridExpanderItem()
							{
								Title = "SubItem_001_002_Content_003"
							},
							new CommandGridExpanderItem()
							{
								Title = "SubItem_001_002_Content_004"
							},
						}
					}
				},
			};
		}

		public void SelectedItemChangedExecute(ProjectItemViewModel selectedItem)
		{
			Debug.WriteLine($"{nameof(SelectedItemChangedExecute)} is called.");

			try
			{
				var selectedItemValue = _itemCommandDictionary?[selectedItem.Name];
				SelectedItem = (null == selectedItemValue) ? SelectedItem : selectedItemValue;
			}
			catch (Exception ex)
			when (ex is KeyNotFoundException)
			{
				// Ignore command.
			}
		}
	}
}
