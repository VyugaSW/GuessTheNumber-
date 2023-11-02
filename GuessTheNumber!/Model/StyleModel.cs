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
using System.Diagnostics;
using System.ComponentModel;

using System.Windows.Threading;

namespace GuessTheNumber_.Model
{
    public class StyleModel : INotifyPropertyChanged
    {
        private Style _styleText;
        private Style _styleWindow;
        private Style _styleMenu;
        private Style _styleButton;

        public Style StyleText
        { 
            get => _styleText;
            set
            {
                _styleText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StyleText)));
            }
        }
        public Style StyleWindow
        {
            get => _styleWindow;
            set
            {
                _styleWindow = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StyleWindow)));
            }
        }
        public Style StyleMenu
        {
            get => _styleMenu;
            set
            {
                _styleMenu = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StyleMenu)));
            }
        }
        public Style StyleButton
        {
            get => _styleButton;
            set
            {
                _styleButton = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StyleButton)));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
