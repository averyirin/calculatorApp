using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace CalculatorApp {
    [Activity(Label = "CalculatorApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity {


        decimal firstNumber = 0;
        decimal secondNumber = 0;
        decimal resultNumber = 0;

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
            TextView textDisplay = (TextView)FindViewById(Resource.Id.textDisplay);



            /* Button 1 */
            btn1.Click += delegate {
                addToCurrentDisplayedValue(textDisplay, "1");
            };

            /* Button 2 */
            btn2.Click += delegate {
                addToCurrentDisplayedValue(textDisplay, "2");
            };

            /* Button 3 */
            btn3.Click += delegate {
                addToCurrentDisplayedValue(textDisplay, "3");
            };

            /* Button 4 */
            btn4.Click += delegate {
                addToCurrentDisplayedValue(textDisplay, "4");
            };

            /* Button 5 */
            btn5.Click += delegate {
                addToCurrentDisplayedValue(textDisplay, "5");
            };

            /* Button 6 */
            btn6.Click += delegate {
                addToCurrentDisplayedValue(textDisplay, "6");
            };

            /* Button 7 */
            btn7.Click += delegate {
                addToCurrentDisplayedValue(textDisplay, "7");
            };

            /* Button 8 */
            btn8.Click += delegate {
                addToCurrentDisplayedValue(textDisplay, "8");
            };

            /* Button 9 */
            btn9.Click += delegate {
                addToCurrentDisplayedValue(textDisplay, "9");
            };

            /* Button 0 */
            btn0.Click += delegate {
                addToCurrentDisplayedValue(textDisplay, "0");
            };



            /* 
             10 > 1
             4 > 0
             0.1 > 0.
             0. > 0
             0
             */
            /* Button Delete */
            btnDelete.Click += delegate {
                string currentStringVal = getCurrentDisplayedValue(textDisplay.Text);
                if (currentStringVal != "0") {
                    string removedText = currentStringVal.Substring(0, currentStringVal.Length - 1);
                    if (removedText == "") {
                        removedText = "0";
                    }
                    if (textDisplay.Text.Contains("-")) {
                        textDisplay.Text = "-" + removedText;
                    }
                    else {
                        textDisplay.Text = removedText;
                    }
                }
            };
            
            /* Button Clear */
            btnClear.Click += delegate {
                clearDisplay(textDisplay);
            };


            /* Button Decimal */
            btnDecimal.Click += delegate {
                addDecimalToDisplay(textDisplay); 
            };

            /* Button Plus/Minus */
            btnPlusMinus.Click += delegate {
                toggleNegative(textDisplay);
            };
        }

        private void saveNumberToMemory(TextView display) {

        }

        private void clearDisplay(TextView display) {
            display.Text = "0";
        }

        /*  
            0 > 5
            5 > 50
            0 > 0.
            1 > 1.
        */

        private string getCurrentDisplayedValue(string currentDisplayVal) {
            if (currentDisplayVal.Contains("-")) {
                return currentDisplayVal.Substring(1, currentDisplayVal.Length-1);
            }else {
                return currentDisplayVal;
            }
        }

        private void addDecimalToDisplay(TextView display) {
            if (display.Text.Contains(".") == false) {
                display.Text += ".";
            }
        }
        
        private void updateValues(string displayNumber) {
            if(firstNumber != 0) {
                firstNumber = decimal.Parse(displayNumber);

            }else {
                secondNumber = decimal.Parse(displayNumber);
            }
        }

        private void addToCurrentDisplayedValue(TextView display, string val) {
            // 0 > 1, -0 > -1, 5 > 15, -5 > -15
            if (display.Text.Contains("-")) {
                //-0 > -1
                 if (getCurrentDisplayedValue(display.Text) == "0") {
                    display.Text = "-"+val;
                }
                //-1 > -15
                else {
                    display.Text += val;
                }
            }
            else {
                //0 > 1
                if (getCurrentDisplayedValue(display.Text) == "0") {
                    display.Text = val;
                }
                //1 > 15
                else {
                    display.Text += val;
                }
            }
        }
        

        private void toggleNegative(TextView display) {
            //toggle positive and negative
            if (display.Text.Contains("-") == false) {
                display.Text = "-" + display.Text;
            }
            else {
                display.Text = display.Text.Substring(1, display.Text.Length-1);
            }
        }

    }

}

