namespace MrGesturesMaui8RC1;

public partial class App : Application
{
	public App()
	{
        MR.Gestures.Border b = new MR.Gestures.Border();
        b.BackgroundColor = Colors.Green;
        b.Up += async (a, b) =>
        {
            ContentPage cp2 = null;
            var b1 = new Button() { Text = "Back" };
            b1.Clicked += async (a, b) =>
            {
                var np = MainPage as NavigationPage;
                await np.Navigation.PopAsync();
            };
            cp2 = new ContentPage()
            {
                Content = b1
            };

            var np = MainPage as NavigationPage;
            await np.Navigation.PushAsync(cp2, true);

        };

        var cp = new ContentPage()
        {
            Content = b
        };



        /*App.MainPage = new CodeMarkup.Maui.NavigationPage()
        {
            p
        };*/
        MainPage = new NavigationPage(cp);
    }
}

