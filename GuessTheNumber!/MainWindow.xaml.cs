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
        private string _difficult = "Medium";
        private string _color = "Green";
        private WindowViewChanger _windowChanger;

        public MainWindow()
        {
            InitializeComponent();
            _windowChanger = new WindowViewChanger(Menu, MainWindowName, StartGameButton, ExitButton);
        }

        private void AboutProgramItem_Click(object sender, RoutedEventArgs e)
        {
            AboutProgramm aboutProgramm = new AboutProgramm();  
            aboutProgramm.Show();
        }


        private void StartGameButton_Click(object sender, RoutedEventArgs e)
        {
            GameProcessWindow GameWindow = new GameProcessWindow(_difficult, _color);
            Hide();     
            GameWindow.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void ColorSubItem_Click(object sender, RoutedEventArgs e)
        {
            _color = (sender as MenuItem).Header.ToString().Replace("_", "");
            _windowChanger.ChangeCheked(sender, ColorItem);
            _windowChanger.ChangeProgramColor(_color);
        }

        private void DifficultSubItem_Click(object sender, RoutedEventArgs e)
        {
            _difficult = (sender as MenuItem).Header.ToString().Replace("_", "");
            _windowChanger.ChangeCheked(sender, DifficultItem);            
        }
    }
}
