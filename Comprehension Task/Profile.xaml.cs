using Comprehension_Task.View;

namespace Comprehension_Task;

public partial class Profile : ContentPage
{
	public Profile()
	{
		InitializeComponent();
	}

    private async void OnEditClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProfileView());
    }
}