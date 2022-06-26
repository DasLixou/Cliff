using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Media;
using Cliff.Design.Components;
using Cliff.Design.Windows;
using System;
using System.Windows.Input;

namespace Cliff.Design.Commands
{
    internal class EditTrackCommand : ICommand
    {
        private TrackController _controller;

        public EditTrackCommand(TrackController controller)
        {
            _controller = controller;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            var window = new TrackEditWindow();
            window.ViewModel().BarColor = _controller.BarColor;
            window.ViewModel().Label = _controller.Label;

            var lifetime = (IClassicDesktopStyleApplicationLifetime)App.Current.ApplicationLifetime;

            window.ShowDialog(lifetime.MainWindow);
        }
    }
}
