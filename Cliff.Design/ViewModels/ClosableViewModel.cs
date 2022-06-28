using System;
using System.Runtime.CompilerServices;

namespace Cliff.Design.ViewModels
{
    public abstract class ClosableViewModel : BaseViewModel
    {
        public event Action OnRequestClose;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RequestClose() => OnRequestClose?.Invoke();
    }
}
