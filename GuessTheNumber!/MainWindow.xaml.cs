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

using GuessTheNumber_.Properties;

namespace GuessTheNumber_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void ChangeProgramColor(string color)
        {
            ResourceDictionary styles = Application.Current.Resources;
            switch (color)
            {
                case "Green":
                    MainWindowName.Style = (Style)styles["StyleWindowGreen"];
                    Menu.Style = (Style)styles["StyleMenuGreen"];
                    StartGameButton.Style = (Style)styles["StyleButtonGreen"];
                    ExitButton.Style = (Style)styles["StyleButtonGreen"];
                    break;
                case "Violet":
                    MainWindowName.Style = (Style)styles["StyleWindowViolet"];
                    Menu.Style = (Style)styles["StyleMenuViolet"];
                    StartGameButton.Style = (Style)styles["StyleButtonViolet"];
                    ExitButton.Style = (Style)styles["StyleButtonViolet"];
                    break;
                case "Red":
                    MainWindowName.Style = (Style)styles["StyleWindowRed"];
                    Menu.Style = (Style)styles["StyleMenuRed"];
                    StartGameButton.Style = (Style)styles["StyleButtonRed"];
                    ExitButton.Style = (Style)styles["StyleButtonRed"];
                    break;
            }
        }


        private void AboutProgramItem_Click(object sender, RoutedEventArgs e)
        {
            AboutProgramm aboutProgramm = new AboutProgramm();  
            aboutProgramm.Show();
        }


        private void StartGameButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

        }


        private void ColorSubItem_Click(object sender, RoutedEventArgs e)
        {
            foreach (MenuItem item in ColorItem.Items)
            {
                if (item.IsChecked == true)
                    item.IsChecked = false;
            }

            (sender as MenuItem).IsChecked = true;
            ChangeProgramColor((sender as MenuItem).Header.ToString().Replace("_", ""));
        }

    }
}
