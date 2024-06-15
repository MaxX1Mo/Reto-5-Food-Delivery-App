namespace Reto_5_Food_Delivery_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
