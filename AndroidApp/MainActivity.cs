using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidApp
{
    [Activity(Label = "AndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
            var Validator = new PCLProyect.AppValidator(new AndroidDialog(this));
            Validator.EMail = "francisco_renan-dt@hotmail.com";
            Validator.Password = "zxxzpa6413";
            Validator.Device = Android.Provider.Settings.Secure.GetString(ContentResolver,Android.Provider.Settings.Secure.AndroidId);
            Validator.Validate();
        }
    }
}

