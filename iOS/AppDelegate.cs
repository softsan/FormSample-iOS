using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;
using FormSample;

namespace MobileRecruiter.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate,  ILoginManager
    {
        UIWindow window;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();

            window = new UIWindow(UIScreen.MainScreen.Bounds);

            window.RootViewController = App.GetMainPage(this).CreateViewController();
            window.MakeKeyAndVisible();
			
            return true;
        }

        public void ShowMainPage()
        {
            window.RootViewController = App.GetMainPage(this).CreateViewController();
            window.MakeKeyAndVisible();
        }

        public void ShowLoginPage()
        {
            window.RootViewController = App.GetLoginPage(this).CreateViewController();
            window.MakeKeyAndVisible();
        }
    }
}

