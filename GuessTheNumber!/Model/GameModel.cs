using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Windows.Threading;
using System.Windows.Controls;

namespace GuessTheNumber_
{
    public class GameModel : INotifyPropertyChanged
    {
        private int _timer;
        private int _randomNumber;
        private int _userNumber;

        public int Timer 
        { 
            get => _timer;
            set
            {
                _timer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Timer)));
            }
        }
        public int RandomNumber
        {
            get => _randomNumber;
            set
            {
                _randomNumber = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RandomNumber)));
            }
        }
        public int UserNumber
        {
            get => _userNumber;
            set
            {
                _userNumber = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UserNumber)));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
