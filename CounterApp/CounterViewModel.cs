using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CounterProject
{
    public class CounterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _counter;

		public int Counter
		{
			get { return _counter; }
			set { _counter = value;OnPropertyChanged("Counter"); }
		}
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }

        public ICommand IncrementCommand { get;}
        public ICommand DecrementCommand { get;}
        public CounterViewModel()
        {
            IncrementCommand = new RelayCommand(Plus);
            DecrementCommand = new RelayCommand(Minus);
        }

        public void Plus()
        {
            Counter++;
        }
        public void Minus()
        {
            Counter--;
        }


    }
}
