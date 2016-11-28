using EdgeNote.Library.Objects;
using EdgeNote.UI.Managers;
using HydrantWiki.Forms;
using Xamarin.Forms;

namespace EdgeNote.UI
{
    public partial class EdgeNoteApp : Application
    {
        public static string DataFolder;
        public static string ImageFolder;
        public static int ScreenWidth;
        public static int ScreenHeight;

        public static User User { get; set; }
        public IPlatformManager m_PlatformManager;

        public EdgeNoteApp(
            IPlatformManager _platformManager)
        {
            m_PlatformManager = _platformManager;

            DataFolder = m_PlatformManager.DataFolder;
            ImageFolder = m_PlatformManager.ImageFolder;

            EdgeNoteManager manager = EdgeNoteManager.GetInstance();
            manager.PlatformManager = m_PlatformManager;

            User = manager.SettingManager.GetUser();

            // The root page of your application
            MainPage = new MainForm();
        }

        public IPlatformManager PlatformManager
        {
            get
            {
                return m_PlatformManager;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}