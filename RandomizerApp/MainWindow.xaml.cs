using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RandomizerApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public object m_dataContext;

		public MainWindow()
		{
			InitializeComponent();
			m_dataContext = new UserListViewModel();
			DataContext = m_dataContext;
		}

		private void CreateNewListDialog()
		{
			var window = new CreateNewListDialog();
			window.ShowDialog();
			window.DataContext = m_dataContext;
		}

		private void OpenUserFile()
		{
			var window = new OpenUserFile();
			window.ShowDialog();
			window.DataContext = m_dataContext;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			CreateNewListDialog();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			OpenUserFile();
		}
	}
}
