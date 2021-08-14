using KevinTicTacToe.Local.ViewModel;
using KevinTicTacToe.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KevinTicTacToe
{
    public class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            GameView window = new();
            window.DataContext = new GameViewModel();
            window.ShowDialog();
            Environment.Exit(0);
        }
    }
}
