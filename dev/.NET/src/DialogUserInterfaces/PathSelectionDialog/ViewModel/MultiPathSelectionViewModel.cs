using DialogUserInterfaces.Command;
using Logger;

namespace DialogUserInterfaces.ViewModel
{
	internal class MultiPathSelectionViewModel : ViewModelBase
	{
		protected readonly string _splitter = ";";

		protected DelegateCommand? _addNewItemCommand = null;

		protected int _mode = Mode.DIALOG_FOLDER_SELECT;

		public DelegateCommand AddNewItemCommand
		{
			get
			{
				if (null == _addNewItemCommand)
				{
					_addNewItemCommand = new DelegateCommand(AddNewItem);
				}
				return _addNewItemCommand;
			}
		}

		protected DelegateCommand? _deleteItemCommand = null;

		public DelegateCommand DeleteItemCommand
		{
			get
			{
				if (null == _deleteItemCommand)
				{
					_deleteItemCommand = new DelegateCommand(RemoveItem);
				}
				return _deleteItemCommand;
			}
		}

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
			Log.TRACE();
			Log.DEBUG($"{nameof(_mode),12} = {_mode}");

			var contentViewModel = new ButtonListBoxViewModel(_mode);
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
			Log.TRACE();

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
			Log.TRACE();

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
			Log.TRACE();

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
			Log.TRACE();

			_mode = Mode.DIALOG_FOLDER_SELECT;
			UserInputPathViewModel = new();
		}

		/// <summary>
		/// Constructor with mode.
		/// </summary>
		/// <param name="mode">Path selection mode.</param>
		public MultiPathSelectionViewModel(int mode) : base()
		{
			Log.TRACE();
			Log.DEBUG($"{"mode",12} = {mode}");

			_mode = mode;
			UserInputPathViewModel = new ButtonListBoxViewModel(mode);
		}

		/// <summary>
		/// Add new item to user input path item.
		/// </summary>
		public virtual void AddNewItem()
		{
			Log.TRACE();

			UserInputPathViewModel.AddNewItem();
		}

		/// <summary>
		/// Remove a item from userInputPathViewModel.
		/// </summary>
		public virtual void RemoveItem()
		{
			Log.TRACE();

			UserInputPathViewModel.DeleteItem();
		}
	}
}
