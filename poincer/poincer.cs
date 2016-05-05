using Xamarin.Forms;

namespace poincer
{
	public class App : Application
	{
		public App ()
		{
		    References.NavigationPage = new NavigationPage(new poincer.MainPage());
            // The root page of your application
            MainPage = References.NavigationPage;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}

    public static class References
    {
        public static NavigationPage NavigationPage { get; set; }
    }
}

