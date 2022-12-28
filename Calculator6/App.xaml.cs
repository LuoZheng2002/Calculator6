using Calculator6.Models;
using Calculator6.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator6
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        MainWindow _mainWindow;
        Model _model;
        protected override void OnStartup(StartupEventArgs e)
        {
            _mainWindow = new MainWindow();
            _model = new Model();
            _mainWindow.DataContext = new MainViewModel(_model);
            _mainWindow.Show();
            base.OnStartup(e);
        }
    }
}
