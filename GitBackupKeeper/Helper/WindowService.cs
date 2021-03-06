﻿using System;
using System.Linq;
using System.Windows;

namespace GitBackupKeeper.Helper
{
    class WindowService
    {
        public void showWindow(String title,object viewModel)
        {
            Window win = new Window();
            win.Owner = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            win.Content = viewModel;
            win.Title = title;
            win.Height = 400;
            win.Width = 450;
            win.Show();
        }
    }
}
