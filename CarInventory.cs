using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInventoryNicholasShortt
{
    public partial class CarInventory : System.Windows.Forms.Form
    {
        private List<Car> carList = new List<Car>();
        private bool isAutomated = false;

        public CarInventory()
        {
            InitializeComponent();
        }

        #region "Event Handler"

        private void FormLoad(object sender, EventArgs e)
        {
            const int NUMBER_OF_YEARS = 100;
            // Fill the year drop down upto the defined constant
            for (int year = DateTime.Today.Year; year >= DateTime.Today.Year - NUMBER_OF_YEARS; year--)
            {
                comboBoxYear.Items.Add(year);
            }
        }

        /// <summary>
        /// When a user trys to check a box in the list view, keep it as it was.
        /// </summary>
        private void PreventCheck(object sender, ItemCheckEventArgs e)
        {
            // Only prevent checking if it is the user
            if (!isAutomated)
            {
                // Make the new value equal to the old value to preven change.
                e.NewValue = e.CurrentValue;

                // Message on attempt to check a box in view list.
                labelResult.Text = "Go away human.";
            }
        }

        /// <summary>
        /// When a car in the list view is select write the car properties into the controls.
        /// </summary>
        private void CarSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewEntries.Items.Count > 0 && listViewEntries.FocusedItem != null)
            {               
                comboBoxMake.Text = listViewEntries.FocusedItem.SubItems[2].Text;
                textBoxModel.Text = listViewEntries.FocusedItem.SubItems[3].Text;
                comboBoxYear.Text = listViewEntries.FocusedItem.SubItems[4].Text;
                textBoxPrice.Text = listViewEntries.FocusedItem.SubItems[5].Text;

                checkBoxNew.Checked = listViewEntries.FocusedItem.Checked;
            }
        }

        /// <summary>
        /// When the button is click the enter values will attempt to be added to the collection, or
        /// if a car is currently selected a message will display a summary of it's details
        /// </summary>
        private void EnterButton(object sender, EventArgs e)
        {     
            // Clear the label
            labelResult.Text = String.Empty;

            // Check if no car is selected
            if (listViewEntries.FocusedItem == null)
            {
                // Decalare varaibles
                double price;
                int year;
                               
                // Check if price is numeric
                if (double.TryParse(textBoxPrice.Text, out price))
                {
                    // Validate the entry feilds
                    if (IsCarValid(comboBoxMake.Text, textBoxModel.Text.Trim(), comboBoxYear.Text, price))
                    {
                        // Pass year entry into an int
                        int.TryParse(comboBoxYear.Text, out year);

                        // Round the price to 2 decimal places
                        price = Math.Round(price, 2);

                        // Create a car object using parametize constructor
                        Car car = new Car(comboBoxMake.Text, textBoxModel.Text.Trim(), year, price, checkBoxNew.Checked);
                        
                        // Add object to list
                        AddToList(car);
                        // Clear entry feilds
                        SetDefaults();
                        // Display success message
                        labelResult.Text = "It worked!";
                    }
                }
                else
                {
                    // Display error if price is not numeric.
                    labelResult.Text += "A price must be entered as a numeric value. Please try again.\n";
                }
            }
            else 
            {
                // Get the ID value of the selected car
                int index;
                int.TryParse(listViewEntries.FocusedItem.SubItems[1].Text, out index);
                // Clear entry feilds
                SetDefaults();
                // Display the car summary for the car in the list using ID number
                labelResult.Text = carList[index -1].GetSummary();
            }
                    
        }

        /// <summary>
        /// Reset the form inputs
        /// </summary>
        private void ResetButton(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Close the form
        /// </summary>
        private void ExitButton(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region "Function"

        /// <summary>
        /// Converts the car passed in to a ListViewItem and adds it to listViewEntries
        /// </summary>
        /// <param name="newCar"></param>
        private void AddToList(Car newCar)
        {
            // Create a new list view object
            ListViewItem carItem = new ListViewItem();

            carItem.Checked = newCar.NewStatus;

            // Add the data from the car object to the list view
            carItem.SubItems.Add(newCar.Id.ToString());
            carItem.SubItems.Add(newCar.Make);
            carItem.SubItems.Add(newCar.Model);
            carItem.SubItems.Add(newCar.Year.ToString());
            carItem.SubItems.Add(newCar.Price.ToString("c"));

            // Ensure we can change the check value and add the item
            isAutomated = true;
            listViewEntries.Items.Add(carItem);
            isAutomated = false;

            // Add the car object to the list of cars
            carList.Add(newCar);
        }


        /// <summary>
        /// Reset the form's input fields to their default state.
        /// </summary>
        private void SetDefaults()
        {
            // Reset fields to default state
            comboBoxMake.SelectedIndex = -1;
            textBoxModel.Clear();
            comboBoxYear.SelectedIndex = -1;
            textBoxPrice.Clear();
            checkBoxNew.Checked = false;
            labelResult.Text = String.Empty;

            // Set the defualt focus
            comboBoxMake.Focus();
        }
        /// <summary>
        /// Validate the car entries
        /// </summary>
        /// <param name="make">Make entry</param>
        /// <param name="model">Model entry</param>
        /// <param name="year">Year entry</param>
        /// <param name="price">Price entry</param>
        /// <returns>Return if the entries are all valid or not</returns>
        private bool IsCarValid(string make, string model, string year, double price)
        {
            bool isValid = true;

            // Check if the make is empty
            if (make == "")
            {
                // Display error message and change to invalid
                labelResult.Text += "A make must be select from the list. Please try again.\n";
                isValid = false;
            }

            // Check if the model is empty
            if (model == "")
            {
                // Display error message and change to invalid
                labelResult.Text += "A model must be entered. Please try again.\n";
                isValid = false;
            }

            // Check if the year is empty
            if (year == "")
            {
                // Display error message and change to invalid
                labelResult.Text += "A year must be select from the list. Please try again.\n";
                isValid = false;
            }

            // Check if the price is negaticce
            if (price < 0)
            {
                // Display error message and change to invalid
                labelResult.Text += "Price cannot be a negative number. Please try again.\n";
                isValid = false;
            }

            return isValid;
        }

        #endregion


    }
}
