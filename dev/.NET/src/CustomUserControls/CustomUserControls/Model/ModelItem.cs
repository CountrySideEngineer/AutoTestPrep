using CustomUserControls.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomUserControls.Model
{
    public class ModelItem<T> : ViewModelBase
    {
        /// <summary>
        /// Item title field.
        /// </summary>
        protected string _title = string.Empty;

        /// <summary>
        /// Item title property.
        /// </summary>
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Item of content field.
        /// </summary>
        protected T _content;

        /// <summary>
        /// Item of content property.
        /// </summary>
        public T Content
        {
            get => _content;
            set
            {
                _content = value;
                RaisePropertyChanged();
            }
        }

		/// <summary>
		/// Default constructor.
		/// </summary>
#pragma warning disable CS8618 // null 非許容のフィールドには、コンストラクターの終了時に null 以外の値が入っていなければなりません。Null 許容として宣言することをご検討ください。
		public ModelItem() : base() { }
#pragma warning restore CS8618 // null 非許容のフィールドには、コンストラクターの終了時に null 以外の値が入っていなければなりません。Null 許容として宣言することをご検討ください。
	}
}
