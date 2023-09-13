namespace MrGesturesMaui8RC1;

public partial class App : Application
{
    bool hasPushed = false;
	public App()
	{
        MR.Gestures.Button bMG = new MR.Gestures.Button() { Text = "MR. Gestures Button - Push Page" };
        bMG.Up += async (a, b) =>
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


        var bStock = new Button() { Text = "Stock Maui Button - Push Page" };
        bStock.Clicked += async (a, b) =>
        {
            if (!hasPushed)
            {
                hasPushed = true;
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
            }
            else
            {
                //Readd event handler as a test on MR Gestures Button.  This then works.
                bMG.Clicked += async (a, b) =>
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
            }

           
        };
        var cp = new ContentPage()
        {
            Content = new StackLayout()
            {
                Children =
                {
                    bStock,
                    bMG
                }
            }
        };
        MainPage = new NavigationPage(cp);
    }
}

