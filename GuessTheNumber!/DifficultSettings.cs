using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;

using System.Windows.Threading;

namespace GuessTheNumber_
{
    public class TimerBar : INotifyPropertyChanged
    {
        private int _timer;
        private DispatcherTimer _dispatcherTimer;
        private int _totalTime;

        public int TotalTime { get; set; }

        public int Timer
        {
            get { return _timer; }
            set
            {
                _timer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GuessTheNumber_.TimerBar)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public TimerBar(int totalTime)
        {
            _totalTime = totalTime;
        }

        public void StartTimer()
        {
            _dispatcherTimer = new DispatcherTimer();
            _dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            _dispatcherTimer.Tick += DispatcherTimer_Tick;
            Timer = _totalTime;
            _dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            Timer--;
            if (Timer == 0)
                _dispatcherTimer.Stop();
        }

    }

    public class DifficultSettings
    {
        public int CountTips { get; set; }
        public int MaxNumber { get; }
        public TimerBar Timer { get; set; }

        public DifficultSettings(int countTips, int maxNumber, int totalTime)
        {
            CountTips = countTips;
            MaxNumber = maxNumber;
            Timer = new TimerBar(totalTime);
        }
    }

    internal static class DifSettingValues
    {
        public static readonly int CountTipsEasy = 500;
        public static readonly int MaxNumberEasy = 100;
        public static readonly int TimeEasy = 1000;

        public static readonly int CountTipsMedium = 5;
        public static readonly int MaxNumberMedium = 500;
        public static readonly int TimeMedium = 80;

        public static readonly int CountTipsHard = 3;
        public static readonly int MaxNumberHard = 1000;
        public static readonly int TimeHard = 30;
    }
}
