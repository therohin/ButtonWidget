using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace UITest
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the Android app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            app = ConfigureApp
                .Android
                // TODO: Update this path to point to your Android app and uncomment the
                // code if the app is not included in the solution.
                .ApkFile (@"C:\Users\Rohin Tak\Documents\Visual Studio 2017\Projects\ButtonWidget\ButtonWidget\bin\Debug\ButtonWidget.ButtonWidget.apk")
                .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void TextView_Shows_Up_When_Button_Clicked()
        {
            app.Tap(c => c.Id("buttonShow"));
            app.Screenshot("Button Pressed");
            AppResult[] result = app.Query(c => c.Id("textViewShow"));
            Assert.IsTrue(result.Any(), "TextView not displayed");

        }
    }
}

