namespace FindYourFuture;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    async private void OnButtonClicked(object sender, EventArgs e)
    {
        if (String.IsNullOrWhiteSpace(usernameEntry.Text) || String.IsNullOrWhiteSpace(passwordEntry.Text))
        {
            await DisplayAlert("Error", "Please fill all the fields", "OK");
        }
        else
        {
            await DisplayAlert("Welcome", $"Hello, {usernameEntry.Text}", "OK");
        }
    }
}

