using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Windows.Threading;
using System.Windows.Controls;

using GuessTheNumber_.Model;

namespace GuessTheNumber_.ViewModel
{
    public class SettingsViewModel
    {
        public SettingModel SettingModel { get; set; }
        public StyleModel StyleModel { get; set; }

        public SettingsViewModel()
        {
            SettingModel = new SettingModel();
            StyleModel = new StyleModel();
            SetStyle("Green");
        }

        public void SetStyle(string color)
        {
            ResourceDictionary style = Application.Current.Resources;
            StyleModel.StyleWindow = style[$"StyleWindow{color}"] as Style;
            StyleModel.StyleButton = style[$"StyleButton{color}"] as Style;
            StyleModel.StyleText = style[$"StyleText{color}"] as Style;
            StyleModel.StyleMenu = style[$"StyleMenu{color}"] as Style;
        }

        public SettingModel SetLevel(int total, int range)
        {
            SettingModel.TotalTime = total;
            SettingModel.Range = range;
            return SettingModel;
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
