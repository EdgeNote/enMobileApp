using EdgeNote.iOS.Managers;
using EdgeNote.UI;
using Foundation;
using UIKit;

namespace EdgeNote.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            PlatformManager pm = new PlatformManager();

            LoadApplication(new EdgeNoteApp(pm));

            return base.FinishedLaunching(app, options);
        }
    }
}
