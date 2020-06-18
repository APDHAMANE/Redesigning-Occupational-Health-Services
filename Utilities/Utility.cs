using System;
using System.Windows.Forms;

namespace Utilities {
    static class Utility {
        static bool Number = false;//For Number.
        static bool KeyHandled = false;//For ComboBox. 

        public static int CalculateAge(int birthYear) {
            int age = 0;
            age = DateTime.Now.Year - birthYear;
            return age;
        }

        public static bool ConvertToInt(string userInput, out int result) {
            return int.TryParse(userInput, out result);
        }

        #region KeyBoard Functions.
    
        public static void ToUpperKeyDown(Object O, KeyEventArgs e) {
            try {
                ComboBox SenderCombo = (ComboBox)O;
                if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z)) {
                    SenderCombo.SelectedText = e.KeyCode.ToString().ToUpper();
                    KeyHandled = true;
                } else {
                    KeyHandled = false;
                }
            } catch (Exception Ex) {
                throw Ex;
            }
        }

        public static void ToUpperKeyPress(Object O, KeyPressEventArgs e) {
            try {
                e.Handled = KeyHandled;
            } catch (Exception Ex) {
                throw Ex;
            }
        }

        //Function For Accepting Only Numbers.
        public static void NumberKeyDown(Object o, KeyEventArgs e) {
            Number = false;
            try {
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) {
                    // Determine whether the keystroke is a number from the keypad. 
                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) {
                        // Determine whether the keystroke is a backspace. 
                        if (e.KeyCode != Keys.Back) {
                            Number = true;
                        }
                    }
                }
                if (Control.ModifierKeys == Keys.Shift) {
                    Number = true;
                }
            } catch (Exception) {
                throw;
            }
        }

        //Function For Accepting Numbers and Dash.
        public static void NumberAndDash(Object o, KeyEventArgs e) {
            Number = false;
            try {
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) {
                    // Determine whether the keystroke is a number from the keypad. 
                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) {
                        // Determine whether the keystroke is a backspace. 
                        if (e.KeyCode != Keys.Back) {
                            if (e.KeyCode != Keys.OemMinus && e.KeyCode != Keys.Subtract) {
                                Number = true;
                            }
                        }
                    }
                }
                if (Control.ModifierKeys == Keys.Shift) {
                    Number = true;
                }
            } catch (Exception) {
                throw;
            }
        }

        //Function For Accepting Numbers and Dot.
        public static void NumberAndDot(Object o, KeyEventArgs e) {
            Number = false;
            try {
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) {
                    // Determine whether the keystroke is a number from the keypad. 
                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) {
                        // Determine whether the keystroke is a backspace. 
                        if (e.KeyCode != Keys.Back) {
                            if (e.KeyCode != Keys.OemPeriod && e.KeyCode != Keys.Decimal) {
                                Number = true;
                            }
                        }
                    }
                }
                if (Control.ModifierKeys == Keys.Shift) {
                    Number = true;
                }
            } catch (Exception) {
                throw;
            }
        }

        //Function For Accepting Nothing.
        public static void Nothing(Object o, KeyEventArgs e) {
            Number = false;
            try {
                if (e.KeyCode >= Keys.A || e.KeyCode <= Keys.Zoom) {
                    Number = true;
                }
                if (Control.ModifierKeys != Keys.Shift) {
                    Number = true;
                }
            } catch (Exception) {
                throw;
            }
        }

        //Key Pressed Event.
        public static void KeyPressed(Object O, KeyPressEventArgs e) {
            try {
                if (Number == true) {
                    // Stop the character from being entered into the control since it is non-numerical.
                    e.Handled = true;
                }
            } catch (Exception) {
                throw;
            }
        }

        #endregion

        public static void DateTimePicker_KeyDown(object sender, KeyEventArgs e) {
            try {
                if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) {
                    ((DateTimePicker)sender).Format = DateTimePickerFormat.Custom;
                    ((DateTimePicker)sender).CustomFormat = " ";
                }
            } catch (Exception E) {
                throw E;
            }
        }
    }
}