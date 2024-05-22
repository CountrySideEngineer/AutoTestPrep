using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
    internal class ProjectItemViewModel : ViewModelBase
    {
		/// <summary>
		/// Project item name field.
		/// </summary>
		protected string _name = string.Empty;

		/// <summary>
		/// Project item name property.
		/// </summary>
		public string Name
		{
			get => _name;
			set
			{
				_name = value;
				RaisePropertyChanged();
			}
		}

		/// <summary>
		/// Collection of ProjetItem object field as sub projects.
		/// </summary>
		protected IEnumerable<ProjectItemViewModel>? _subProjects = null;

		/// <summary>
		/// Collection of ProjectItem object property.
		/// </summary>
		public IEnumerable<ProjectItemViewModel>? SubProjects
		{
			get => _subProjects;
			set
			{
				_subProjects = value;
				RaisePropertyChanged();
			}
		}

		Type? ItemType { get; set; } = null;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ProjectItemViewModel() : base()
		{
			Name = string.Empty;
		}
    }
}
