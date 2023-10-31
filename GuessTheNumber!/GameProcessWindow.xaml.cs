﻿using System;
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
using System.Windows.Shapes;
using System.Diagnostics;


namespace GuessTheNumber_
{
    /// <summary>
    /// Логика взаимодействия для GameProcessWindow.xaml
    /// </summary>



    public partial class GameProcessWindow : Window
    {
        public WindowViewChanger WindowChanger { get; set; }
        private string _color;
        private int _number;
        public DifficultSettings DifficultSettings { get; set; }

        public GameProcessWindow(string difficult, string color)
        {
            WindowChanger = new WindowViewChanger();
            WindowChanger.ChangeProgramColor(color);

            ApplySettings(difficult);
            GenerateNumber();

            InitializeComponent();
            DataContext = this;

            DifficultSettings.Timer.StartTimer();
        }


        private void ApplySettings(string difficult)
        {
            switch (difficult)
            {
                case "Easy":
                    DifficultSettings = new DifficultSettings(DifSettingValues.CountTipsEasy, 
                        DifSettingValues.MaxNumberEasy, DifSettingValues.TimeEasy);
                    break;
                case "Medium":
                    DifficultSettings = new DifficultSettings(DifSettingValues.CountTipsMedium, 
                        DifSettingValues.MaxNumberMedium, DifSettingValues.TimeMedium);
                    break;
                case "Hard":
                    DifficultSettings = new DifficultSettings(DifSettingValues.CountTipsHard, 
                        DifSettingValues.MaxNumberHard, DifSettingValues.TimeHard);
                    break;
            }
        }

        private void GenerateNumber()
        {
            Random random = new Random();
            _number = random.Next(0, DifficultSettings.MaxNumber);
        }

        private void End(string result)
        {
            TextBlockEnd.Text = result;
        }



        private void ColorSubItem_Click(object sender, RoutedEventArgs e)
        {
            _color = (sender as MenuItem).Header.ToString().Replace("_", "");
            WindowChanger.ChangeCheked(sender, ColorItem);
            WindowChanger.ChangeProgramColor(_color);
        }

        private void StopButton_Click(object sender, RoutedEventArgs e) 
        {


            Close();
        }

        private void AboutProgramItem_Click(object sender, RoutedEventArgs e)
        {
            AboutProgramm aboutProgramm = new AboutProgramm();
            aboutProgramm.Show();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(TextBoxNumber.Text) == _number)
                End("WIN");            
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

        private void ProgressBar_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DifficultSettings.Timer.Timer == 0)
            {
                End("LOOSE");
                TextBoxNumber.Text = Convert.ToString(_number);
            }
        }
    }
}
