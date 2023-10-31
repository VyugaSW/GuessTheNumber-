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

namespace GuessTheNumber_
{
    public class Styles
    {
        
    }



    public class WindowViewChanger : INotifyPropertyChanged
    {
        private Style _styleMenu;
        private Style _styleWindow;
        private Style _styleButton1;
        private Style _styleButton2;

        public Style StyleMenu 
        { 
            get => _styleMenu; 
            set
            {
                _styleMenu = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_styleMenu)));
            }             
        }
        public Style StyleWindow
        {
            get => _styleWindow;
            set
            {
                _styleWindow = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_styleMenu)));
            }
        }
        public Style StyleButton1
        {
            get => _styleButton1;
            set
            {
                _styleButton1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_styleMenu)));
            }
        }
        public Style StyleButton2
        {
            get => _styleButton2;
            set
            {
                _styleButton2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_styleMenu)));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void ChangeProgramColor(string color)
        {
            ResourceDictionary styles = Application.Current.Resources;
            switch (color)
            {
                case "Green":
                    StyleWindow = (Style)styles["StyleWindowGreen"];
                    StyleMenu = (Style)styles["StyleMenuGreen"];
                    StyleButton1 = (Style)styles["StyleButtonGreen"];
                    StyleButton2 = (Style)styles["StyleButtonGreen"];
                    break;

                case "Violet":
                    StyleWindow = (Style)styles["StyleWindowViolet"];
                    StyleMenu = (Style)styles["StyleMenuViolet"];
                    StyleButton1 = (Style)styles["StyleButtonViolet"];
                    StyleButton2 = (Style)styles["StyleButtonViolet"];
                    break;

                case "Red":
                    StyleWindow = (Style)styles["StyleWindowRed"];
                    StyleMenu = (Style)styles["StyleMenuRed"];
                    StyleButton1 = (Style)styles["StyleButtonRed"];
                    StyleButton2 = (Style)styles["StyleButtonRed"];
                    break;
            }
        }

        public void ChangeCheked(object sender, MenuItem items)
        {
            foreach (MenuItem item in items.Items)
            {
                if (item.IsChecked == true)
                    item.IsChecked = false;
            }

            (sender as MenuItem).IsChecked = true;
        }
    }
}
