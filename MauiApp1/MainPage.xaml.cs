using CommunityToolkit.Maui.Core.Primitives;
using Microsoft.Maui.Platform;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        void OnPlayPauseButtonClicked(object sender, EventArgs args)
        {
            //if (mediaElement.CurrentState == MediaElementState.Stopped ||
            //    mediaElement.CurrentState == MediaElementState.Paused)
            //{
            //    mediaElement.Play();
            //}
            //else if (mediaElement.CurrentState == MediaElementState.Playing)
            //{
            //    mediaElement.Pause();
            //}
        }

        void OnStopButtonClicked(object sender, EventArgs args)
        {
            //mediaElement.Stop();
        }

        void ContentPage_Unloaded(object? sender, EventArgs e)
        {
            // Stop and cleanup MediaElement when we navigate away
            //mediaElement.Handler?.DisconnectHandler();
        }


        private void mediaElement_StateChanged(object sender, CommunityToolkit.Maui.Core.Primitives.MediaStateChangedEventArgs e)
        {
            //if (e.NewState == MediaElementState.Paused)
            //{
            //    // Do something
            //    var state = mediaElement.CurrentState;
            //    var time = mediaElement.Position;
            //    // Format the TimeSpan to a string
            //    string? timeString = string.Format("{0:D2}:{1:D2}:{2:D2}",
            //        time.Hours, time.Minutes, time.Seconds);

            //    // Set the formatted string to the Text property of the Label
            //    currentTime.Text = timeString;
            //}
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //var time = mediaElement.Position;
            //string? timeString = string.Format("{0:D2}:{1:D2}:{2:D2}",
            //    time.Hours, time.Minutes, time.Seconds);
            //currentTime.Text = timeString;
        }
    }
}