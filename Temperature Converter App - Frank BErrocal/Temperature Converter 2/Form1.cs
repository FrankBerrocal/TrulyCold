/*  Frank Berrocal
 *  Learning Activity 1
 *  September 2023
 *  Prof.  Dima Marachi.
 *  Software Development
 *  Bow Valley College
 * 
 */


namespace Temperature_Converter_2
{
    public partial class tempConverterForm : Form
    {

        public tempConverterForm()
        {
            InitializeComponent();
        }

        //listening to actions in all buttons, watching if the first typed character is zero.  
        private void buttonClickEvent(object sender, EventArgs e)
        {

            Button TemperatureButton = (Button)sender;

            if (displayTempLabel.Text.Contains("-0") && TemperatureButton.Text == "0")
            {
                displayTempLabel.Text = "-0.";
            }
            else if (TemperatureButton.Text != "0")
            {
                displayTempLabel.Text = displayTempLabel.Text + TemperatureButton.Text;
            }
            else if (TemperatureButton.Text == "0" && displayTempLabel.Text.Length == 0)
            {
                displayTempLabel.Text = "";
            }
            else if (TemperatureButton.Text == "0" && displayTempLabel.Text.Length > 0)
            {
                displayTempLabel.Text = displayTempLabel.Text + TemperatureButton.Text;
            }


        }

        //clears the data in both display and results labels.
        private void clearButton_Click(object sender, EventArgs e)
        {
            displayTempLabel.Text = "";
            resultConversionLabel.Text = "";
        }

        //deletes the las charactr from the display label.
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (displayTempLabel.Text.Length > 0)
            {
                displayTempLabel.Text = displayTempLabel.Text.Remove(displayTempLabel.Text.Length - 1, 1);
            }
            else { displayTempLabel.Text = ""; }
        }

        //inserts a dot in the number, if empty, inserts 0.
        private void inputButtonDot_Click(object sender, EventArgs e)
        {
            Button TemperatureButton = (Button)sender;
            if (displayTempLabel.Text.Length == 0)
            {
                displayTempLabel.Text = "0.";
            }
            else if (displayTempLabel.Text.Contains("."))
            {
                //do nothing
            }
            else
            {
                displayTempLabel.Text = displayTempLabel.Text + TemperatureButton.Text;
            }
        }

        //This event is adding or eliminating the negative sign.
        private void inputButtonSign_Click(object sender, EventArgs e)
        {
            Button TemperatureButton = (Button)sender;

            if (displayTempLabel.Text.Contains('-'))
            {
                displayTempLabel.Text = displayTempLabel.Text.Remove(0, 1);
            }
            else if (displayTempLabel.Text.Length > 0)
            {
                displayTempLabel.Text = "-" + displayTempLabel.Text;
            }
            else
            {
                displayTempLabel.Text = "-";
            }


        }


        private void tempConverterForm_Load(object sender, EventArgs e)
        {
            conversionSelectorStartBox.Text = ("Conversion Start");
            conversionSelectorStartBox.Items.Add("Fahrenheit");
            conversionSelectorStartBox.Items.Add("Celsius");
            conversionSelectorStartBox.Items.Add("Kelvin");


            conversionSelectionEndBox.Text = ("Conversion End");
            conversionSelectionEndBox.Items.Add("Fahrenheit");
            conversionSelectionEndBox.Items.Add("Celsius");
            conversionSelectionEndBox.Items.Add("Kelvin");
        }

        private void conversionSelectionEndBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            temperatureCalculations();
        }

        private void temperatureCalculations()
        {
            if (displayTempLabel.Text == "")
            {
                //MessageBox.Show("Enter a temperature to convert and a route");
                //do nothing
            }
            else if (displayTempLabel.Text == "-")
            {
                // do nothing
            }

            else
            {
                double tempValue = double.Parse(displayTempLabel.Text);

                if (conversionSelectorStartBox.SelectedIndex == 0 && conversionSelectionEndBox.SelectedIndex == 1)
                {
                    //F to C
                    if (tempValue > 0)
                    {
                        tempValue = (tempValue - 32) * 5 / 9;
                        tempValue = Math.Truncate(tempValue * 100) / 100;
                        //displayTempLabel.Text = "";
                        resultConversionLabel.Text = tempValue.ToString() + " C";
                    }
                    else
                    {
                        MessageBox.Show("Input Fahrenheit cannot be negative");
                        resultConversionLabel.Text = "Error";
                    }


                }
                else if (conversionSelectorStartBox.SelectedIndex == 1 && conversionSelectionEndBox.SelectedIndex == 0)
                {
                    //C to F
                    tempValue = tempValue * 9 / 5 + 32;
                    if (tempValue >= 0)
                    {
                        tempValue = Math.Truncate(tempValue * 100) / 100;
                        resultConversionLabel.Text = tempValue.ToString() + " F";
                    }
                    else
                    {
                        resultConversionLabel.Text = "Error";
                    }


                }
                else if (conversionSelectorStartBox.SelectedIndex == 1 && conversionSelectionEndBox.SelectedIndex == 2)
                {
                    //C to K
                    tempValue = tempValue + 273.15;
                    if (tempValue >= 0)
                    {
                        tempValue = Math.Truncate(tempValue * 100) / 100;
                        resultConversionLabel.Text = tempValue.ToString() + " K";
                    }
                    else
                    {
                        resultConversionLabel.Text = "Error";
                    }


                }
                else if (conversionSelectorStartBox.SelectedIndex == 0 && conversionSelectionEndBox.SelectedIndex == 2)
                {
                    //F to K
                    if (tempValue > 0)
                    {
                        tempValue = (tempValue - 32) * 5 / 9 + 273.15;
                        if (tempValue >= 0)
                        {
                            tempValue = Math.Truncate(tempValue * 100) / 100;
                            resultConversionLabel.Text = tempValue.ToString() + " K";
                        }
                        else
                        {
                            resultConversionLabel.Text = "Error";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input Fahrenheit cannot be negative");
                        resultConversionLabel.Text = "Error";
                    }



                }
                else if (conversionSelectorStartBox.SelectedIndex == 2 && conversionSelectionEndBox.SelectedIndex == 1)
                {
                    //K to C
                    if (tempValue > 0)
                    {
                        tempValue = tempValue - 273.15;
                        tempValue = Math.Truncate(tempValue * 100) / 100;
                        //displayTempLabel.Text = "";
                        resultConversionLabel.Text = tempValue.ToString() + " C";
                    }
                    else
                    {
                        MessageBox.Show("Input Kelvin cannot be negative");
                        resultConversionLabel.Text = "Error";
                    }

                }
                else if (conversionSelectorStartBox.SelectedIndex == 2 && conversionSelectionEndBox.SelectedIndex == 0)
                {
                    //K to F
                    if (tempValue > 0)
                    {
                        tempValue = (tempValue - 273.15) * 9 / 5 * 32;
                        if (tempValue >= 0)
                        {
                            tempValue = Math.Truncate(tempValue * 100) / 100;
                            resultConversionLabel.Text = tempValue.ToString() + " F";
                        }
                        else
                        {
                            resultConversionLabel.Text = "Error";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input Kelvin cannot be negative");
                        resultConversionLabel.Text = "Error";
                    }

                }
                else if (conversionSelectorStartBox.SelectedIndex == 0 && conversionSelectionEndBox.SelectedIndex == 0)
                {
                    //F to F
                    tempValue = tempValue;
                    if (tempValue >= 0)
                    {
                        resultConversionLabel.Text = tempValue.ToString() + " F";
                    }
                    else
                    {
                        resultConversionLabel.Text = "Error";
                    }
                }
                else if (conversionSelectorStartBox.SelectedIndex == 1 && conversionSelectionEndBox.SelectedIndex == 1)
                {
                    //C to C
                    tempValue = tempValue;
                    resultConversionLabel.Text = tempValue.ToString() + " C";

                }
                else if (conversionSelectorStartBox.SelectedIndex == 2 && conversionSelectionEndBox.SelectedIndex == 2)
                {
                    //K to K
                    tempValue = tempValue;
                    if (tempValue >= 0)
                    {
                        resultConversionLabel.Text = tempValue.ToString() + " K";
                    }
                    else
                    {
                        resultConversionLabel.Text = "Error";
                    }
                }
                else
                {
                    //MessageBox.Show("Select Start and End of conversion");
                }
            }
        }

        private void autoUpdateTemperatureCalculations(object sender, EventArgs e)
        {
            temperatureCalculations();
        }

        private void conversionSelectorStartBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //necesito que cambie con el primer combo box.
            temperatureCalculations();
        }
    }
}