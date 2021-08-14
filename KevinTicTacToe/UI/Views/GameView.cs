using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KevinTicTacToe.UI.Views
{
    public class GameView : Window
    {
        static GameView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameView), new FrameworkPropertyMetadata(typeof(GameView)));
        }

        public GameView()
        {
            WindowStyle = WindowStyle.None;
            AllowsTransparency = true;
        }
    }
}
