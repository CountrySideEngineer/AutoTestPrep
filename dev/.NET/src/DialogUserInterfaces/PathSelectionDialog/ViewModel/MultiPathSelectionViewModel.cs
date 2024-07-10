using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DialogUserInterfaces.ViewModel
{
	internal class MultiPathSelectionViewModel : ViewModelBase
	{
		protected readonly string _splitter = ";";

		/// <summary>
		/// Title of window.
		/// </summary>
		public string Title { get => Properties.Resources.IDS_WINDOW_TITLE; }

		/// <summary>
		/// Title of OK button.
		/// </summary>
		public string OkTitle { get => Properties.Resources.IDS_OK_BUTTON_TITLE; }

		/// <summary>
		/// Title of cancel button.
		/// </summary>
		public string CancelTitle { get => Properties.Resources.IDS_CANCEL_BUTTON_TITLE; }

		/// <summary>
		/// View model of sub control.
		/// </summary>
		protected ButtonListBoxViewModel _userInputPathViewModel = new();

		/// <summary>
		/// View model of sub control.
		/// </summary>
		public ButtonListBoxViewModel UserInputPathViewModel
		{
			get => _userInputPathViewModel;
			set
			{
				_userInputPathViewModel = value;
				RaisePropertyChange();
			}
		}

		/// <summary>
		/// Set content of path selection.
		/// </summary>
		/// <param name="content">Content of path.</param>
		public virtual void SetContent(IEnumerable<string> content)
		{
			var contentViewModel = new ButtonListBoxViewModel();
			contentViewModel.SetContent(content);

			UserInputPathViewModel = contentViewModel;
		}

		/// <summary>
		/// Set contetn of path selection.
		/// </summary>
		/// <param name="content">Content of path as string.</param>
		/// <param name="splitter">Splitter of content.</param>
		public virtual void SetContent(string content, string splitter = ";")
		{
			IEnumerable<string> splitContent =
				content
				.Split(splitter, StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			SetContent(splitContent);
		}

		/// <summary>
		/// Get content of dialog.
		/// </summary>
		/// <returns>Content of dialog in generics.</returns>
		public virtual IEnumerable<string> GetContent()
		{
			var content = new List<string>();
			foreach (var item in UserInputPathViewModel.Items)
			{
				content.Add(item.InputItem);
			}
			return content;
		}

		/// <summary>
		/// Get content of dialog as one line string.
		/// </summary>
		/// <param name="splitter">Code to split item in the dialog.</param>
		/// <returns>Content of dialog in string.</returns>
		public virtual string GetContent(string splitter)
		{
			IEnumerable<string> contents = GetContent();
			string contentOneLine = string.Empty;
			foreach (var content in contents)
			{
				contentOneLine += content;
				contentOneLine += splitter;
			}
			return contentOneLine;
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MultiPathSelectionViewModel() : base()
		{
			UserInputPathViewModel = new();
		}
	}
}
