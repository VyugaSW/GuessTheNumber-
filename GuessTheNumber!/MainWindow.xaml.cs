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
using GuessTheNumber_.Model;
using GuessTheNumber_.ViewModel;

namespace GuessTheNumber_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
  
    public partial class MainWindow : Window
    {
        public SettingsViewModel SettingsViewModel { get; set; }

        private string _difficult = "Medium";
        private string _color = "Green";

        public MainWindow()
        {
            InitializeComponent();

            SettingsViewModel = new SettingsViewModel();
            DataContext = this;
        }

        public MainWindow(string color)
        {
            _color = color;
            SettingsViewModel = new SettingsViewModel();
            SettingsViewModel.SetStyle(color);

            InitializeComponent();

            DataContext = this;
        }

        private void AboutProgramItem_Click(object sender, RoutedEventArgs e)
        {
            AboutProgramm aboutProgramm = new AboutProgramm();  
            aboutProgramm.Show();
        }


        private void StartGameButton_Click(object sender, RoutedEventArgs e)
        {
            GameProcessWindow GameWindow = new GameProcessWindow(_difficult, _color);
            Close();     
            GameWindow.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ColorSubItem_Click(object sender, RoutedEventArgs e)
        {
            _color = (sender as MenuItem).Header.ToString().Replace("_", "");
            SettingsViewModel.ChangeCheked(sender, ColorItem);
            SettingsViewModel.SetStyle(_color);
        }

        private void DifficultSubItem_Click(object sender, RoutedEventArgs e)
        {
            _difficult = (sender as MenuItem).Header.ToString().Replace("_", "");
            SettingsViewModel.ChangeCheked(sender, DifficultItem);            
        }

        private void MenuItemClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItemNewGame_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.Show();
        }
    }
}
