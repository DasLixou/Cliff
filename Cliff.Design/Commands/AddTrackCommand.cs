using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Media;
using Cliff.Design.Windows;
using System;
using System.Windows.Input;

namespace Cliff.Design.Commands
{
    internal class AddTrackCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            var window = new TrackEditWindow();
            window.ViewModel().BarColor = Brushes.Black;
            window.ViewModel().Label = "New Track";
            window.ViewModel().Controller = null;

            var lifetime = (IClassicDesktopStyleApplicationLifetime)App.Current.ApplicationLifetime;

            window.ShowDialog(lifetime.MainWindow);
        }
    }
}
