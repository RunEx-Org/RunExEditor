using System;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace RunExEditor
{
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window
	{
		const string folder = @"\RunExEditor";
		readonly string appFolder;

		public MainWindow()
		{
			string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			appFolder = appData + folder;

			if (!Directory.Exists(appFolder))
			{
				Directory.CreateDirectory(appFolder);
			}
			InitializeComponent();
		}

		private void Exit_Button(object sender, RoutedEventArgs e)
		{
			Environment.Exit(1);
		}

		private void OpenRegEdit_Button(object sender, RoutedEventArgs e)
		{
			string message = "レジストリエディタによる変更は、パソコンが動かなくなる危険性があります。\n開きますか?";

			if (MessageBoxResult.Yes == MessageBox.Show(message,"警告", MessageBoxButton.YesNo, MessageBoxImage.Warning))
			{
				Process.Start("regedit.exe");
			}
		}
	}
}
