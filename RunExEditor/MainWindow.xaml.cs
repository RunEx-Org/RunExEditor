using System;
using System.Diagnostics;
using System.Windows;

namespace RunExEditor
{
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Exit_Button(object sender, RoutedEventArgs e)
		{
			Environment.Exit(1);
		}

		private void OpenRegEdit_Button(object sender, RoutedEventArgs e)
		{
			if(MessageBoxResult.Yes == MessageBox.Show("レジストリエディタによる変更は、パソコンが動かなくなる危険性があります。\n開きますか?","警告", MessageBoxButton.YesNo, MessageBoxImage.Warning))
			{
				Process.Start("regedit.exe");
			}
		}
	}
}
