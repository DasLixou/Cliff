using Cliff.Design.Components;
using System.Collections.ObjectModel;

namespace Cliff.Design.ViewModels
{
    internal class LibraryWidgetViewModel : BaseViewModel
    {
        public ObservableCollection<LibraryEntry> LibraryEntries { get; set; } = new();

        public LibraryWidgetViewModel()
        {
            LibraryEntries.Add(new LibraryEntry { Label = "Lixou's Kick 808" });
            LibraryEntries.Add(new LibraryEntry { Label = "Lixou's Snare 808" });
            LibraryEntries.Add(new LibraryEntry { Label = "bass lines yeah" });
        }
    }
}
