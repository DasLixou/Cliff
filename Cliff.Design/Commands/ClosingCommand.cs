using Cliff.Design.ViewModels;
using System;
using System.Windows.Input;

namespace Cliff.Design.Commands
{
    internal class ClosingCommand : ICommand
    {
        private ClosableViewModel viewModel;

        public ClosingCommand(ClosableViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => viewModel.RequestClose();
    }
}