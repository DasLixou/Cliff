using Cliff.Design.Components;
using NAudio.Wave;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows.Input;

namespace Cliff.Design.ViewModels
{
    internal class LibraryWidgetViewModel : BaseViewModel
    {
        public ObservableCollection<LibraryEntry> LibraryEntries { get; set; } = new();

        public LibraryWidgetViewModel()
        {
            LibraryEntries.Add(new LibraryEntry { Label = "Lixou's Kick 808", Command = new PlayCommand() });
            LibraryEntries.Add(new LibraryEntry { Label = "Lixou's Snare 808", Command = new PlayCommand() });
            LibraryEntries.Add(new LibraryEntry { Label = "bass lines yeah", Command = new PlayCommand() });
        }
    }

    internal class PlayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            using (var audioFile = new AudioFileReader("Assets/Samples/lixoubass.wav"))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
            }
        }
    }
}
