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

        private void PreventCheck(object sender, ItemCheckEventArgs e)
        {
            // Only prevent checking if it is the user
            if (isAutomated)
            {
                // Make the new value equal to the old value to preven change.
                e.NewValue = e.CurrentValue;
            }
        }

        private void EnterButton(object sender, EventArgs e)
        {

        }

        private void ResetButton(object sender, EventArgs e)
        {

        }

        private void ExitButton(object sender, EventArgs e)
        {
            Close();
        }
    }
}
