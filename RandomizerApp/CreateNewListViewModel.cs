using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RandomizerApp
{
	class CreateNewListViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public ICommand CommitTextCommand { get; } = new ButtonClickCommand();

		public CreateNewListViewModel()
		{
			
		}

		public class ButtonClickCommand : ICommand
		{
			public event EventHandler CanExecuteChanged;

			public bool	CanExecute(object param)
			{
				return true;
			}

			public void Execute(object param)
			{
				if(param != null)
				{
					//var myString = UserInput.Text;
				}
			}
		}
	}
}
