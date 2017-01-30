using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace CalculatorApp {
    [Activity(Label = "CalculatorApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);


            // Get all of our number buttons
            Button btn1 = (Button)FindViewById(Resource.Id.btn1);
            Button btn2 = (Button)FindViewById(Resource.Id.btn2);
            Button btn3 = (Button)FindViewById(Resource.Id.btn3);
            Button btn4 = (Button)FindViewById(Resource.Id.btn4);
            Button btn5 = (Button)FindViewById(Resource.Id.btn5);
            Button btn6 = (Button)FindViewById(Resource.Id.btn6);
            Button btn7 = (Button)FindViewById(Resource.Id.btn7);
            Button btn8 = (Button)FindViewById(Resource.Id.btn8);
            Button btn9 = (Button)FindViewById(Resource.Id.btn9);
            Button btn0 = (Button)FindViewById(Resource.Id.btn0);

            //function buttons
           Button btnAdd = (Button)FindViewById(Resource.Id.btnAdd);
           Button btnSubtract = (Button)FindViewById(Resource.Id.btnSubtract);
           Button btnMultiply = (Button)FindViewById(Resource.Id.btnMultiply);
           Button btnDivide = (Button)FindViewById(Resource.Id.btnDivide);
           Button btnEquals = (Button)FindViewById(Resource.Id.btnEquals);
           Button btnClear = (Button)FindViewById(Resource.Id.btnClear);
           Button btnDelete = (Button)FindViewById(Resource.Id.btnDelete);
           Button btnRoot = (Button)FindViewById(Resource.Id.btnRoot);
           Button btnSquared = (Button)FindViewById(Resource.Id.btnSquared);
           Button btnPower = (Button)FindViewById(Resource.Id.btnPower);
           Button btnDecimal = (Button)FindViewById(Resource.Id.btnDecimal);
           Button btnPlusMinus = (Button)FindViewById(Resource.Id.btnPlusMinus);
           Button btnPercent = (Button)FindViewById(Resource.Id.btnPercent);


            //display text
            TextView textDisplay = (TextView) FindViewById(Resource.Id.textDisplay);
           

            /* Button Clear */
            btnClear.Click += delegate {
                textDisplay.Text = "";
            };
        }

    }

}

