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
    public partial class WtfDialog : Form
    {
        private Label wtfLocationLabel;
        private Label wtfNameLabel;
        private TextBox wtfNameTextBox;
        private Button buttonOK;
        private OpenFileDialog wtfOpenDialog;
        private Button buttonOpenWtf;
        private Label label1;
        private Label wtfFileLocationLabel;
        private Label wtfNameHelpLabel;
        private Label wtfNameRemainLengthLabel;
        private Button buttonCancel;
    
        private void InitializeComponent()
        {
            this.wtfLocationLabel = new System.Windows.Forms.Label();
            this.wtfNameLabel = new System.Windows.Forms.Label();
            this.wtfNameTextBox = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.wtfOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenWtf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wtfFileLocationLabel = new System.Windows.Forms.Label();
            this.wtfNameHelpLabel = new System.Windows.Forms.Label();
            this.wtfNameRemainLengthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wtfLocationLabel
            // 
            this.wtfLocationLabel.AutoSize = true;
            this.wtfLocationLabel.Location = new System.Drawing.Point(22, 50);
            this.wtfLocationLabel.Name = "wtfLocationLabel";
            this.wtfLocationLabel.Size = new System.Drawing.Size(74, 13);
            this.wtfLocationLabel.TabIndex = 0;
            this.wtfLocationLabel.Text = "WTF location:";
            this.wtfLocationLabel.Click += new System.EventHandler(this.wtfLocationLabel_Click);
            // 
            // wtfNameLabel
            // 
            this.wtfNameLabel.AutoSize = true;
            this.wtfNameLabel.Location = new System.Drawing.Point(22, 128);
            this.wtfNameLabel.Name = "wtfNameLabel";
            this.wtfNameLabel.Size = new System.Drawing.Size(63, 13);
            this.wtfNameLabel.TabIndex = 1;
            this.wtfNameLabel.Text = "WTF name:";
            this.wtfNameLabel.Click += new System.EventHandler(this.wtfNameLabel_Click);
            // 
            // wtfNameTextBox
            // 
            this.wtfNameTextBox.Location = new System.Drawing.Point(134, 125);
            this.wtfNameTextBox.MaxLength = 64;
            this.wtfNameTextBox.Name = "wtfNameTextBox";
            this.wtfNameTextBox.Size = new System.Drawing.Size(415, 20);
            this.wtfNameTextBox.TabIndex = 1;
            this.wtfNameTextBox.TextChanged += new System.EventHandler(this.wtfNameTextBox_TextChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(134, 227);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.TabStop = false;
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(473, 227);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "Cancel";
            // 
            // wtfOpenDialog
            // 
            this.wtfOpenDialog.FileName = "realmlist";
            this.wtfOpenDialog.Filter = "Warcraft Text Files (*.wtf)|*.wtf";
            this.wtfOpenDialog.Title = "Realmlist.wtf tallozasa";
            // 
            // buttonOpenWtf
            // 
            this.buttonOpenWtf.Location = new System.Drawing.Point(134, 66);
            this.buttonOpenWtf.Name = "buttonOpenWtf";
            this.buttonOpenWtf.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenWtf.TabIndex = 0;
            this.buttonOpenWtf.Text = "Talloz";
            this.buttonOpenWtf.UseVisualStyleBackColor = true;
            this.buttonOpenWtf.Click += new System.EventHandler(this.buttonOpenWtf_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            // 
            // wtfFileLocationLabel
            // 
            this.wtfFileLocationLabel.AutoSize = true;
            this.wtfFileLocationLabel.Location = new System.Drawing.Point(131, 50);
            this.wtfFileLocationLabel.Name = "wtfFileLocationLabel";
            this.wtfFileLocationLabel.Size = new System.Drawing.Size(107, 13);
            this.wtfFileLocationLabel.TabIndex = 6;
            this.wtfFileLocationLabel.Text = "WtfFileLocationLabel";
            this.wtfFileLocationLabel.TextChanged += new System.EventHandler(this.wtfFileLocationLabel_TextChanged);
            // 
            // wtfNameHelpLabel
            // 
            this.wtfNameHelpLabel.AutoSize = true;
            this.wtfNameHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.wtfNameHelpLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wtfNameHelpLabel.Location = new System.Drawing.Point(132, 148);
            this.wtfNameHelpLabel.Name = "wtfNameHelpLabel";
            this.wtfNameHelpLabel.Size = new System.Drawing.Size(74, 12);
            this.wtfNameHelpLabel.TabIndex = 10;
            this.wtfNameHelpLabel.Text = "Any char usable.";
            // 
            // wtfNameRemainLengthLabel
            // 
            this.wtfNameRemainLengthLabel.AutoSize = true;
            this.wtfNameRemainLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.wtfNameRemainLengthLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wtfNameRemainLengthLabel.Location = new System.Drawing.Point(132, 169);
            this.wtfNameRemainLengthLabel.Name = "wtfNameRemainLengthLabel";
            this.wtfNameRemainLengthLabel.Size = new System.Drawing.Size(117, 12);
            this.wtfNameRemainLengthLabel.TabIndex = 11;
            this.wtfNameRemainLengthLabel.Text = "RealmNameRemainLength";
            // 
            // WtfDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(584, 282);
            this.Controls.Add(this.wtfNameRemainLengthLabel);
            this.Controls.Add(this.wtfNameHelpLabel);
            this.Controls.Add(this.wtfFileLocationLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenWtf);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.wtfNameTextBox);
            this.Controls.Add(this.wtfNameLabel);
            this.Controls.Add(this.wtfLocationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WtfDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WtfDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }

    public partial class WtfDialog : Form
    {
        private String oldWtfLocation = "";
        private String oldWtfName = "";

        public WtfDialog()
        {
            InitializeComponent();
            this.Text = "New WTF";
            wtfNameRemainLengthLabel.Text = String.Format("{0} char(s) left", wtfNameTextBox.MaxLength);
            wtfFileLocationLabel.Text = "";
        }
        public WtfDialog(String wtfLocation, String wtfName)
        {
            oldWtfLocation = wtfLocation;
            oldWtfName = wtfName;
            InitializeComponent();
            this.Text = "Modify WTF";
            wtfFileLocationLabel.Text = wtfLocation;
            wtfOpenDialog.FileName = wtfLocation;
            wtfNameTextBox.Text = wtfName;
            wtfNameRemainLengthLabel.Text = String.Format("{0} char(s) left", wtfNameTextBox.MaxLength - wtfName.Length);
        }

        public String WtfName
        {
            get
            {
                return wtfNameTextBox.Text.Trim();
            }
        }
        public String WtfLocation
        {
            get
            {
                return wtfOpenDialog.FileName.Trim();
            }
        }

        private bool checkValidInput()
        {
            if (wtfNameTextBox.TextLength > 0 && wtfFileLocationLabel.Text.Length > 0)
                return true;
            return false;
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
            if (WtfList.IsWtfLocationExists(WtfLocation, oldWtfLocation))
            {
                MessageBox.Show("This WTF location already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if (WtfList.IsWtfNameExists(WtfName, oldWtfName))
            {
                MessageBox.Show("MThis WTF name already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void buttonOpenWtf_Click(object sender, EventArgs e)
        {
            if (wtfOpenDialog.ShowDialog() == DialogResult.OK)
                wtfFileLocationLabel.Text = wtfOpenDialog.FileName;
        }

        private void wtfNameTextBox_TextChanged(object sender, EventArgs e)
        {
            wtfNameRemainLengthLabel.Text = String.Format("{0} char(s) left", wtfNameTextBox.MaxLength - wtfNameTextBox.TextLength);
            validateInput();
        }
        private void wtfFileLocationLabel_TextChanged(object sender, EventArgs e)
        {
            validateInput();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (checkInputExistance())
                DialogResult = DialogResult.None;
            else
                DialogResult = DialogResult.OK;
        }

        private void wtfLocationLabel_Click(object sender, EventArgs e)
        {
            buttonOpenWtf.Focus();
        }
        private void wtfNameLabel_Click(object sender, EventArgs e)
        {
            wtfNameTextBox.Focus();
        }
    }
}
