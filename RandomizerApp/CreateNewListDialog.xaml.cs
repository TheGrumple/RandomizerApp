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
	/// Interaction logic for CreateNewListDialog.xaml
	/// </summary>
	public partial class CreateNewListDialog : Window
	{
		public CreateNewListDialog()
		{
			InitializeComponent();
			DataContext = new CreateNewListViewModel();
		}

		public void btn_Test(object sender, RoutedEventArgs e)
		{
			var myString = UserInput.Text;
		}
	}
}
