using Plugin;
using Plugin.Manager;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestPrep.Command
{
	public class LoadDefaultPluginCommand : LoadPluginCommand
	{
		/// <summary>
		/// Default plugin
		/// </summary>
		public LoadDefaultPluginCommand() : base()
		{
			string currentDir = System.IO.Directory.GetCurrentDirectory();
			string dbPath = $@"{currentDir}\db\DefaultPlugin.plugin";
			string tableName = "DefaultPlugin";
			base.DbPath = dbPath;
			base.DbTableName = tableName;
		}

		/// <summary>
		/// Constructor with argument.
		/// </summary>
		/// <param name="dbPath">Database file path.</param>
		/// <param name="dbTableName">Database table name.</param>
		public LoadDefaultPluginCommand(string dbPath, string dbTableName) : 
			base(dbPath, dbTableName)
		{}

		/// <summary>
		/// Execute load plugin command.
		/// </summary>
		/// <param name="commandArg"></param>
		public override void Execute(object commandArg)
		{
			try
			{
				base.CreateDbDirectroyIfNotExists();
				this.RegistDefaultPluginIfNotExist();
				base.Execute(commandArg);
			}
			catch (System.Exception ex)
			when ((ex is IOException) || (ex is SecurityException))
			{
				Debug.WriteLine(ex.StackTrace);

				throw;
			}
		}

		/// <summary>
		/// Regist default plugin information into a database.
		/// </summary>
		protected virtual void RegistDefaultPluginIfNotExist()
		{
			/*
			 * In a case that the database file does not exist, it will be created
			 * in PluginManager object operation.
			 * So it is not needed to check whether the file exists or not.
			 */

			var manager = new PluginManager(this.DbPath, this.DbTableName);
			var googleTestPluginInfo = new PluginInfo
			{
				Name = "Google test",
				FileName = "GTestStubDriverPlugin.dll"
			};
			this.RegistDefaultPluginIfNotExist(manager, googleTestPluginInfo);
			var minUnitPluginUnfo = new PluginInfo
			{
				Name = "Min unit",
				FileName = "MinUnitStubDriverPlugin.dll"
			};
			this.RegistDefaultPluginIfNotExist(manager, minUnitPluginUnfo);
			var stubCodePlugin = new PluginInfo
			{
				Name = "Stub code",
				FileName = "StubCodePlugin.dll",
			};
			this.RegistDefaultPluginIfNotExist(manager, stubCodePlugin);
		}

		/// <summary>
		/// Regist plugin information inot data base if it is not registered in the database.
		/// </summary>
		/// <param name="pluginManager">Plugin manager.</param>
		/// <param name="pluginInfo">Plugin inforamtion to check.</param>
		protected virtual void RegistDefaultPluginIfNotExist(PluginManager pluginManager, PluginInfo pluginInfo)
		{
			if (!(pluginManager.IsRegistered(pluginInfo)))
			{
				pluginManager.Regist(pluginInfo);
			}
		}
	}
}
