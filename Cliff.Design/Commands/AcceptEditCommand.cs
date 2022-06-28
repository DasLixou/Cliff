using Avalonia.Media;
using Cliff.Design.Components;
using Cliff.Design.ViewModels;
using System;
using System.Windows.Input;

namespace Cliff.Design.Commands
{
    internal class AcceptEditCommand : ICommand
    {
        private TrackEditViewModel viewModel;

        public AcceptEditCommand(TrackEditViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            if (viewModel.Controller == null)
            {
                
            } else
            {
                viewModel.Controller.BarColor = viewModel.BarColor;
                viewModel.Controller.Label = viewModel.Label;
            }
        }
    }
}