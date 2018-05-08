using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RandomizerApp
{
	public class UserListViewModel : INotifyPropertyChanged
	{
		string m_path = @"C:\Users\Eric\Documents\Visual Studio 2015\Projects\RandomizerApp\Lists\testlist.txt";
		private string m_selectedMovie;
		private string[] m_movieArray;
		private List<string> m_movieList;
		private Random m_random = new Random();

		private DelegateCommand m_selectMovieCommand;
		private DelegateCommand m_readListCommand;

		public ICommand SelectMovieCommand => m_selectMovieCommand;
		public ICommand ReadListCommand => m_readListCommand;

		public event PropertyChangedEventHandler PropertyChanged;

		public UserListViewModel()
		{
			m_movieArray = File.ReadAllLines(m_path);
			m_movieList = m_movieArray.ToList();
			m_selectMovieCommand = new DelegateCommand(() => SelectMovie());
			m_readListCommand = new DelegateCommand(() => SelectFromList());
		}

		public string SelectedMovie
		{
			get { return m_selectedMovie; }
			set
			{
				m_selectedMovie = value;
				OnPropertyChanged("SelectedMovie");
			}
		}

		private void RemoveBlankEntries(List<string> Movies)
		{
			var moviesList = new List<string>();
			foreach (string s in Movies)
			{
				if (s != "")
				{
					moviesList.Add(s);
				}
			}
			m_movieList = moviesList;
		}

		private void WriteList()
		{
			File.WriteAllLines(m_path, m_movieList.ToArray());
		}

		public void SelectFromList()
		{
			RemoveBlankEntries(m_movieList);
			// Check for the array size and only execute if the array size is non-zero
			if (m_movieList.Count() <= 0)
			{
				SelectedMovie = "No movies in the list!";
			}
			else
			{
				var listSize = m_movieList.Count;
				var readList = m_movieList;
				var randomItem = m_random.Next(0, listSize);
				var selectedItem = readList.ElementAt(randomItem);
				readList.RemoveAt(randomItem);
				m_movieArray = readList.ToArray();
				SelectedMovie = selectedItem;
			}
		}

		public void CreateNewList(string ListName)
		{
			var newMovieList = new UserMovieList();
			newMovieList.ListName = ListName;

		}

		public void SelectMovie()
		{
			SelectFromList();
			WriteList();
		}

		protected void OnPropertyChanged(string name)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(name));
			}
		}
	}
}
