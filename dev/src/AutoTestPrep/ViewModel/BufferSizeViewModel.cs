using AutoTestPrep.Model.InputInfos;
using CSEngineer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.ViewModel
{
	public class BufferSizeViewModel : AutoTestPrepViewModelBase
	{
		/// <summary>
		/// Field of view model of buffer size 1.
		/// </summary>
		protected SizeInputViewModel _BufferSize1VM;

		/// <summary>
		/// Field of view model of buffer size 2.
		/// </summary>
		protected SizeInputViewModel _BufferSize2VM;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public BufferSizeViewModel() : this(-1) { }

		public BufferSizeViewModel(int index) : base(index)
		{
			this.BufferSize1VM = new SizeInputViewModel("バッファサイズ1", 100);
			this.BufferSize2VM = new SizeInputViewModel("バッファサイズ2", 100);
		}

		/// <summary>
		/// Propety of view model of buffer size 1.
		/// </summary>
		public SizeInputViewModel BufferSize1VM
		{
			get
			{
				return this._BufferSize1VM;
			}
			set
			{
				this._BufferSize1VM = value;
				this.RaisePropertyChanged(nameof(BufferSize1VM));
			}
		}

		/// <summary>
		/// Property of view model of bueer size 2.
		/// </summary>
		public SizeInputViewModel BufferSize2VM
		{
			get
			{
				return this._BufferSize2VM;
			}
			set
			{
				this._BufferSize2VM = value;
				this.RaisePropertyChanged(nameof(BufferSize2VM));
			}
		}

		/// <summary>
		/// Value of buffer size 1.
		/// </summary>
		public long BufferSize1
		{
			get
			{
				return this.BufferSize1VM.ItemValue;
			}
			set
			{
				this.BufferSize1VM.ItemValue = value;
			}
		}

		/// <summary>
		/// Value of buffer size 2.
		/// </summary>
		public long BufferSize2
		{
			get
			{
				return this.BufferSize2VM.ItemValue;
			}
			set
			{
				this.BufferSize2VM.ItemValue = value;
			}
		}

		/// <summary>
		/// Setup test user input data into
		/// Set the data entered by users in the object specified by the argument.
		/// </summary>
		/// <param name="testDataInfo">Object to set input data.</param>
		public override void SetupTestInfomation(ref TestDataInfo testDataInfo)
		{
			testDataInfo.StubBufferSize1 = this.BufferSize1;
			testDataInfo.StubBufferSize2 = this.BufferSize2;
		}

		/// <summary>
		/// Restore the data in object specified by argument.
		/// </summary>
		/// <param name="testDataInfo">Source data object.</param>
		public override void RestoreTestInforamtion(TestDataInfo testDataInfo)
		{
			this.BufferSize1 = testDataInfo.StubBufferSize1;
			this.BufferSize2 = testDataInfo.StubBufferSize2;
		}
	}
}
