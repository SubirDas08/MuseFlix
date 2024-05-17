using CommunityToolkit.Maui.Core.Primitives;

namespace MauiApp1;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    void OnPlayPauseButtonClicked(object sender, EventArgs args)
    {
        if (mediaElement.CurrentState == MediaElementState.Stopped ||
            mediaElement.CurrentState == MediaElementState.Paused)
        {
            mediaElement.Play();
        }
        else if (mediaElement.CurrentState == MediaElementState.Playing)
        {
            mediaElement.Pause();
        }
        currentTime.Text = mediaElement.Position.ToString();
    }

    void OnStopButtonClicked(object sender, EventArgs args)
    {
        mediaElement.Stop();
    }
}