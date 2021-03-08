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
                comboBoxModel.Text = listViewEntries.FocusedItem.SubItems[1].Text;
                textBoxModel.Text = listViewEntries.FocusedItem.SubItems[2].Text;
                comboBoxYear.Text = listViewEntries.FocusedItem.SubItems[3].Text;
                textBoxPrice.Text = listViewEntries.FocusedItem.SubItems[4].Text;
            }
        }

        private void EnterButton(object sender, EventArgs e)
        {

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
        {​​
            // Declare and instantiate a new ListViewItem.
            ListViewItem carItem = new ListViewItem();

            isAutomated = true;

            carItem.Checked = newCar.NewStatus;
            carItem.SubItems.Add(newCar.Id.ToString());
            carItem.SubItems.Add(newCar.Make);
            carItem.SubItems.Add(newCar.Model);
            carItem.SubItems.Add(newCar.Year.ToString());
            carItem.SubItems.Add(newCar.Price.ToString());



            // Add the carItem to the ListView.
            listViewEntries.Items.Add(carItem);

            isAutomated = false;
        }​​

        /// <summary>
        /// Reset the form's input fields to their default state.
        /// </summary>
        private void SetDefaults()
        {
            // Reset fields to default state
            comboBoxModel.SelectedIndex = -1;
            textBoxModel.Clear();
            comboBoxYear.SelectedIndex = -1;
            textBoxPrice.Clear();
            checkBoxNew.Checked = false;

            // Set the defualt focus
            comboBoxModel.Focus();
        }

        #endregion


    }
}
