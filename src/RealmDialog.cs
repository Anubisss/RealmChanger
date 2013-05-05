/*
 * This file is part of RealmChanger.
 *
 * RealmChanger is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.

 * RealmChanger is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.

 * You should have received a copy of the GNU General Public License
 * along with RealmChanger.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Windows.Forms;

namespace RealmChanger
{
    public partial class RealmDialog : Form
    {
        private Label realmNameLabel;
        private TextBox realmAddressTextBox;
        private TextBox realmNameTextBox;
        private Button buttonOK;
        private Button buttonCancel;
        private Label realmAddressRemainLengthLabel;
        private Label realmNameRemainLengthLabel;
        private Label realmAddressHelpLabe;
        private Label realmNameHelpLabel;
        private Label realmAddressLabel;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealmDialog));
            this.realmAddressLabel = new System.Windows.Forms.Label();
            this.realmNameLabel = new System.Windows.Forms.Label();
            this.realmAddressTextBox = new System.Windows.Forms.TextBox();
            this.realmNameTextBox = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.realmAddressRemainLengthLabel = new System.Windows.Forms.Label();
            this.realmNameRemainLengthLabel = new System.Windows.Forms.Label();
            this.realmAddressHelpLabe = new System.Windows.Forms.Label();
            this.realmNameHelpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // realmAddressLabel
            // 
            resources.ApplyResources(this.realmAddressLabel, "realmAddressLabel");
            this.realmAddressLabel.Name = "realmAddressLabel";
            this.realmAddressLabel.Click += new System.EventHandler(this.realmAddressLabel_Click);
            // 
            // realmNameLabel
            // 
            resources.ApplyResources(this.realmNameLabel, "realmNameLabel");
            this.realmNameLabel.Name = "realmNameLabel";
            this.realmNameLabel.Click += new System.EventHandler(this.realmNameLabel_Click);
            // 
            // realmAddressTextBox
            // 
            resources.ApplyResources(this.realmAddressTextBox, "realmAddressTextBox");
            this.realmAddressTextBox.Name = "realmAddressTextBox";
            this.realmAddressTextBox.TextChanged += new System.EventHandler(this.realmAddressTextBox_TextChanged);
            // 
            // realmNameTextBox
            // 
            resources.ApplyResources(this.realmNameTextBox, "realmNameTextBox");
            this.realmNameTextBox.Name = "realmNameTextBox";
            this.realmNameTextBox.TextChanged += new System.EventHandler(this.realmNameTextBox_TextChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.TabStop = false;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.TabStop = false;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // realmAddressRemainLengthLabel
            // 
            resources.ApplyResources(this.realmAddressRemainLengthLabel, "realmAddressRemainLengthLabel");
            this.realmAddressRemainLengthLabel.Name = "realmAddressRemainLengthLabel";
            // 
            // realmNameRemainLengthLabel
            // 
            resources.ApplyResources(this.realmNameRemainLengthLabel, "realmNameRemainLengthLabel");
            this.realmNameRemainLengthLabel.Name = "realmNameRemainLengthLabel";
            // 
            // realmAddressHelpLabe
            // 
            resources.ApplyResources(this.realmAddressHelpLabe, "realmAddressHelpLabe");
            this.realmAddressHelpLabe.Name = "realmAddressHelpLabe";
            // 
            // realmNameHelpLabel
            // 
            resources.ApplyResources(this.realmNameHelpLabel, "realmNameHelpLabel");
            this.realmNameHelpLabel.Name = "realmNameHelpLabel";
            // 
            // RealmDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.buttonCancel;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.realmNameHelpLabel);
            this.Controls.Add(this.realmAddressHelpLabe);
            this.Controls.Add(this.realmNameRemainLengthLabel);
            this.Controls.Add(this.realmAddressRemainLengthLabel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.realmNameTextBox);
            this.Controls.Add(this.realmAddressTextBox);
            this.Controls.Add(this.realmNameLabel);
            this.Controls.Add(this.realmAddressLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RealmDialog";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }

    public partial class RealmDialog : Form
    {
        private String oldRealmAddress = "";
        private String oldRealmName = "";

        public RealmDialog()
        {
            InitializeComponent();
            this.Text = "New realm";
            realmAddressRemainLengthLabel.Text = String.Format("{0} char(s) left", realmAddressTextBox.MaxLength);
            realmNameRemainLengthLabel.Text = String.Format("{0} char(s) left", realmNameTextBox.MaxLength);
        }
        public RealmDialog(String realmAddress, String realmName)
        {
            InitializeComponent();
            this.Text = "Modify realm";
            realmAddressTextBox.Text = realmAddress;
            realmNameTextBox.Text = realmName;
            realmAddressRemainLengthLabel.Text = String.Format("{0} char(s) left", realmAddressTextBox.MaxLength - realmAddress.Length);
            realmNameRemainLengthLabel.Text = String.Format("{0} char(s) left", realmNameTextBox.MaxLength - realmName.Length);

            oldRealmAddress = realmAddress;
            oldRealmName = realmName;
            // new realm address from a WTF
            if (realmName == "")
                realmAddressTextBox.Enabled = false;
        }

        public String RealmAddress
        {
            get
            {
                return realmAddressTextBox.Text.Trim();
            }
        }
        public String RealmName
        {
            get
            {
                return realmNameTextBox.Text.Trim();
            }
        }

        private static readonly String realmAddressChars = "abcdefghijklmnopqrstuvwxzyz0123456789-.:";
        private bool checkValidInput()
        {
            if (String.IsNullOrEmpty(realmAddressTextBox.Text) || String.IsNullOrEmpty(realmNameTextBox.Text))
                return false;
            else
            {
                foreach (Char c in realmAddressTextBox.Text)
                    if (!realmAddressChars.Contains(c.ToString()))
                        return false;
                return true;
            }

        }
        private void validateInput()
        {
            if (checkValidInput())
                buttonOK.Enabled = true;
            else
                buttonOK.Enabled = false;
        }

        private bool checkInputExistance()
        {
            if (RealmList.IsRealmAddressExists(RealmAddress, oldRealmName == "" ? "" : oldRealmAddress))
            {
                MessageBox.Show("This realm address already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if (RealmList.IsRealmNameExists(RealmName, oldRealmName))
            {
                MessageBox.Show("This realm name already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void realmAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            validateInput();
            realmAddressRemainLengthLabel.Text = String.Format("{0} char(s) left", realmAddressTextBox.MaxLength - realmAddressTextBox.TextLength);
        }

        private void realmNameTextBox_TextChanged(object sender, EventArgs e)
        {
            validateInput();
            realmNameRemainLengthLabel.Text = String.Format("{0} char(s) left", realmNameTextBox.MaxLength - realmNameTextBox.TextLength);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (checkInputExistance())
                DialogResult = DialogResult.None;
            else
                DialogResult = DialogResult.OK;
        }

        private void realmAddressLabel_Click(object sender, EventArgs e)
        {
            realmAddressTextBox.Focus();
        }
        private void realmNameLabel_Click(object sender, EventArgs e)
        {
            realmNameTextBox.Focus();
        }
    }
}
