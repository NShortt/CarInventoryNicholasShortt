
namespace CarInventoryNicholasShortt
{
    partial class CarInventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBoxNew = new System.Windows.Forms.CheckBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMake = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.listViewEntries = new System.Windows.Forms.ListView();
            this.columnHeaderNew = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMake = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderModel = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderYear = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPrice = new System.Windows.Forms.ColumnHeader();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // checkBoxNew
            // 
            this.checkBoxNew.AutoSize = true;
            this.checkBoxNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxNew.Enabled = false;
            this.checkBoxNew.Location = new System.Drawing.Point(101, 234);
            this.checkBoxNew.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxNew.Name = "checkBoxNew";
            this.checkBoxNew.Size = new System.Drawing.Size(86, 34);
            this.checkBoxNew.TabIndex = 8;
            this.checkBoxNew.Text = "&New:";
            this.checkBoxNew.UseVisualStyleBackColor = true;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(160, 178);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(223, 35);
            this.textBoxLastName.TabIndex = 7;
            this.toolTip.SetToolTip(this.textBoxLastName, "Enter the price of the car.");
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(21, 178);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(131, 30);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "&Price:";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelModel
            // 
            this.labelModel.Location = new System.Drawing.Point(21, 69);
            this.labelModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(131, 30);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "M&odel:";
            this.labelModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(160, 69);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(223, 35);
            this.textBoxFirstName.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxFirstName, "Enter the car\'s model.");
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 30;
            this.comboBox1.Items.AddRange(new object[] {
            "Dr.",
            "Duchess",
            "Duke",
            "Hon.",
            "Lady",
            "Lord",
            "Mr.",
            "Mrs.",
            "Ms.",
            "Mx.",
            "Sir"});
            this.comboBox1.Location = new System.Drawing.Point(160, 122);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 38);
            this.comboBox1.TabIndex = 5;
            this.toolTip.SetToolTip(this.comboBox1, "Select the year the car was made.");
            // 
            // labelYear
            // 
            this.labelYear.Location = new System.Drawing.Point(21, 125);
            this.labelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(131, 30);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "&Year:";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMake
            // 
            this.labelMake.Location = new System.Drawing.Point(21, 16);
            this.labelMake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(131, 30);
            this.labelMake.TabIndex = 0;
            this.labelMake.Text = "&Make:";
            this.labelMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Items.AddRange(new object[] {
            "Dr.",
            "Duchess",
            "Duke",
            "Hon.",
            "Lady",
            "Lord",
            "Mr.",
            "Mrs.",
            "Ms.",
            "Mx.",
            "Sir"});
            this.comboBoxModel.Location = new System.Drawing.Point(160, 13);
            this.comboBoxModel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(224, 38);
            this.comboBoxModel.TabIndex = 1;
            this.toolTip.SetToolTip(this.comboBoxModel, "Select the car\'s make.");
            // 
            // labelResult
            // 
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Location = new System.Drawing.Point(21, 526);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(546, 88);
            this.labelResult.TabIndex = 10;
            this.toolTip.SetToolTip(this.labelResult, "Display message about attempt to add to list.");
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(436, 626);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(131, 40);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to close the form.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitButton);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(299, 626);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(131, 40);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to clear entry fields.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ResetButton);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(162, 626);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(131, 40);
            this.buttonEnter.TabIndex = 11;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to enter data to the list.");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.EnterButton);
            // 
            // listViewEntries
            // 
            this.listViewEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNew,
            this.columnHeaderID,
            this.columnHeaderMake,
            this.columnHeaderModel,
            this.columnHeaderYear,
            this.columnHeaderPrice});
            this.listViewEntries.HideSelection = false;
            this.listViewEntries.Location = new System.Drawing.Point(21, 275);
            this.listViewEntries.MultiSelect = false;
            this.listViewEntries.Name = "listViewEntries";
            this.listViewEntries.Size = new System.Drawing.Size(546, 241);
            this.listViewEntries.TabIndex = 9;
            this.toolTip.SetToolTip(this.listViewEntries, "Display lists of entered data.");
            this.listViewEntries.UseCompatibleStateImageBehavior = false;
            this.listViewEntries.View = System.Windows.Forms.View.Details;
            this.listViewEntries.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PreventCheck);
            // 
            // columnHeaderNew
            // 
            this.columnHeaderNew.Text = "New";
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderMake
            // 
            this.columnHeaderMake.Text = "Make";
            this.columnHeaderMake.Width = 120;
            // 
            // columnHeaderModel
            // 
            this.columnHeaderModel.Text = "Model";
            this.columnHeaderModel.Width = 120;
            // 
            // columnHeaderYear
            // 
            this.columnHeaderYear.Text = "Year";
            this.columnHeaderYear.Width = 80;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 100;
            // 
            // CarInventory
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(598, 678);
            this.Controls.Add(this.listViewEntries);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.checkBoxNew);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelMake);
            this.Controls.Add(this.labelModel);
            this.Name = "CarInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxNew;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.ListView listViewEntries;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ColumnHeader columnHeaderNew;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderMake;
        private System.Windows.Forms.ColumnHeader columnHeaderModel;
        private System.Windows.Forms.ColumnHeader columnHeaderYear;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
    }
}

