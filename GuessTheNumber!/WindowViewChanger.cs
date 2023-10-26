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

namespace GuessTheNumber_
{
    public class WindowViewChanger
    {
        private Menu _menu;
        private Window _nameWindow;
        private Button _startGameButton;
        private Button _exitGameButton;

        public WindowViewChanger(Menu menu, Window window, Button button1, Button button2)
        {
            _menu = menu;
            _nameWindow = window;
            _startGameButton = button1;
            _exitGameButton = button2;
        }

        public void ChangeProgramColor(string color)
        {
            ResourceDictionary styles = Application.Current.Resources;
            switch (color)
            {
                case "Green":
                    _nameWindow.Style = (Style)styles["StyleWindowGreen"];
                    _menu.Style = (Style)styles["StyleMenuGreen"];
                    _startGameButton.Style = (Style)styles["StyleButtonGreen"];
                    _exitGameButton.Style = (Style)styles["StyleButtonGreen"];
                    break;

                case "Violet":
                    _nameWindow.Style = (Style)styles["StyleWindowViolet"];
                    _menu.Style = (Style)styles["StyleMenuViolet"];
                    _startGameButton.Style = (Style)styles["StyleButtonViolet"];
                    _exitGameButton.Style = (Style)styles["StyleButtonViolet"];
                    break;

                case "Red":
                    _nameWindow.Style = (Style)styles["StyleWindowRed"];
                    _menu.Style = (Style)styles["StyleMenuRed"];
                    _startGameButton.Style = (Style)styles["StyleButtonRed"];
                    _exitGameButton.Style = (Style)styles["StyleButtonRed"];
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
