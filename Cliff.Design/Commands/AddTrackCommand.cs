using Cliff.Design.Windows;
using System;
using System.Windows.Input;

namespace Cliff.Design.Commands
{
    internal class AddTrackCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => new TrackEditWindow().Show();
    }
}
