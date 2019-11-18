using Xamarin.Forms;



namespace AirPnP

{

    public class MainPageCS : TabbedPage

    {

        public MainPageCS()

        {

            var navigationPage = new NavigationPage(new SchedulePageCS());//replace with new link

            navigationPage.IconImageSource = "schedule.png";

            navigationPage.Title = "Schedule";



            Children.Add(new TodayPageCS());//replace with new link

            Children.Add(navigationPage);

            Children.Add(new SettingsPage());//replace with new link

        }

    }

}