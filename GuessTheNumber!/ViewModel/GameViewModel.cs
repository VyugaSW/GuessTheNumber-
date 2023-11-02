using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Threading;

namespace GuessTheNumber_.ViewModel
{
    public class GameViewModel
    {
        public GameModel Game { get; set; }
        private SettingsViewModel settingsViewModel;

        public GameViewModel()
        {
            Game = new GameModel();
            settingsViewModel = new SettingsViewModel();
        }

        public void StartTimer()
        {
            DispatcherTimer _dispatcherTimer = new DispatcherTimer();
            _dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            _dispatcherTimer.Tick += (sender, e) =>
            {
                Game.Timer--;
                if (Game.Timer == 0)
                    _dispatcherTimer.Stop();
            };

            Game.Timer = settingsViewModel.SetLevel(20,1).TotalTime;
            _dispatcherTimer.Start();
        }

    }
}
