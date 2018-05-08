﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RandomizerApp
{
	class DelegateCommand : ICommand
	{
		public event EventHandler CanExecuteChanged;
		public Action m_exeAction;

		public DelegateCommand(Action exeAction)
		{
			m_exeAction = exeAction;
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			m_exeAction.Invoke();
		}
	}
}
