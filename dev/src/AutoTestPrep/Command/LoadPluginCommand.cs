﻿using Plugin;
using Plugin.Manager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.Command
{
	public class LoadPluginCommand : ACommonPluginCommand
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		protected LoadPluginCommand()
		{
			this.DbPath = string.Empty;
			this.DbTableName = string.Empty;
		}

		/// <summary>
		/// Constructor with argument,
		/// </summary>
		/// <param name="dbPath">Path to database information to load are registered.</param>
		/// <param name="dbTableName">Name of table in database.</param>
		public LoadPluginCommand(string dbPath, string dbTableName)
		{
			this.DbPath = dbPath;
			this.DbTableName = dbTableName;
		}

		/// <summary>
		/// Execute loading plugin datas.
		/// </summary>
		/// <param name="commandArg">Reference to set loaded plugin infos.</param>
		/// <exception cref="ArgumentException">Argument is invalid.</exception>
		public override void Execute(object commandArg)
		{
			try
			{
				ObservableCollection<PluginInfo> pluginInfos = (ObservableCollection<PluginInfo>)commandArg;

				var pluginManager = new PluginManager(this.DbPath, this.DbTableName);
				var pluginList = pluginManager.GetList();

				pluginInfos.Clear();
				foreach (var pluginListItem in pluginList)
				{
					pluginInfos.Add(pluginListItem);
				}
			}
			catch (System.Exception ex)
			when ((ex is NullReferenceException) || (ex is InvalidCastException))
			{
				throw new ArgumentException();
			}
		}

		/// <summary>
		/// Create output directory if it has not been exists.
		/// </summary>
		/// <remarks>This is for classes inherit this class.
		/// </remarks>
		protected virtual void CreateDbDirectroyIfNotExists()
		{
			DirectoryInfo dbFileDirInfo = new DirectoryInfo(this.DbPath);
			DirectoryInfo dbFileParentDirInfo = dbFileDirInfo.Parent;
			if (!dbFileParentDirInfo.Exists)
			{
				dbFileParentDirInfo.Create();
			}
		}
	}
}
