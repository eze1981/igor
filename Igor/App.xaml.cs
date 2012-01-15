using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Igor.Utils.Keyboard;
using System.Diagnostics;

namespace Igor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Window _window; 
        private readonly KeyboardListener _keyboardListener;

        public App()
        {
            _window = new MainWindow();
            _keyboardListener = new KeyboardListener();
        }

        private void ApplicationStartup(object sender, StartupEventArgs e)
        {
            _keyboardListener.KeyDown += new RawKeyEventHandler(KeyboardListenerKeyDown);

            if (Debugger.IsAttached)
                _window.Hide();
        }

        void KeyboardListenerKeyDown(object sender, RawKeyEventArgs args)
        {
            _window.Dispatcher.BeginInvoke(new Action(() =>
            {
                if (args.Key == Key.LeftCtrl)
                    _window.Show();
            }), null);
            
            //_window.Activate();
        }

        private void ApplicationExit(object sender, ExitEventArgs e)
        {
            _keyboardListener.Dispose();
        }
    }
}
