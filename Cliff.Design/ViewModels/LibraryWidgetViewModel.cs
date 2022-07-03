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

        private static IWavePlayer outputDevice;
        private static AudioFileReader audioFile;

        private static void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice?.Dispose();
            outputDevice = null;
            audioFile?.Dispose();
            audioFile = null;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            outputDevice?.Stop();

            outputDevice = new WaveOutEvent();
            outputDevice.PlaybackStopped += OnPlaybackStopped;

            audioFile = new AudioFileReader("Assets/Samples/lixoubass.wav");
            outputDevice.Init(audioFile);

            outputDevice.Play();
        }
    }
}
