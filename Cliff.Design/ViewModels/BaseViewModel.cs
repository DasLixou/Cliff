﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Cliff.Design.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnChange([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        protected void SetValue<T>(ref T field, T value, [CallerMemberName] string property = null)
        {
            if (Equals(field, value))
                return;

            field = value;

            OnChange(property);
        }
    }
}
