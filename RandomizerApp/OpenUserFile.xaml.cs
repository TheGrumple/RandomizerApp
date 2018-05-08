using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RandomizerApp
{
	/// <summary>
	/// Interaction logic for OpenUserFile.xaml
	/// </summary>
	public partial class OpenUserFile : Window
	{
		public OpenUserFile()
		{
			InitializeComponent();
		}

		private void btnOpenFile_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == true)
				txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
		}
	}
}
