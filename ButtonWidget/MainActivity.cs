using Android.App;
using Android.Widget;
using Android.OS;

namespace ButtonWidget
{
    [Activity(Label = "ButtonWidget", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button buttonShow = FindViewById<Button>(Resource.Id.buttonShow);
            buttonShow.Click += ButtonShow_Click;
        }

        private void ButtonShow_Click(object sender, System.EventArgs e)
        {
            TextView text = FindViewById<TextView>(Resource.Id.textViewShow);
            text.Visibility = Android.Views.ViewStates.Visible;
        }
    }
}

