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
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace RealmChanger
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            realmListComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            wtfListComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cleanStatusMessage();
        }

        private void checkListsEmpty()
        {
            if (RealmList.IsEmpty())
            {
                realmListComboBox.Visible = false;
                deleteRealmButton.Visible = false;
                modifyRealmButton.Visible = false;
                selectedRealmAddressLabel.Text = "";
            }
            else
            {
                realmListComboBox.Visible = true;
                deleteRealmButton.Visible = true;
                modifyRealmButton.Visible = true;
            }

            if (WtfList.IsEmpty())
            {
                wtfListComboBox.Visible = false;
                deleteWtfButton.Visible = false;
                modifyWtfButton.Visible = false;
                selectedWtfLocationLabel.Text = "";
                startClientButton.Visible = false;
            }
            else
            {
                wtfListComboBox.Visible = true;
                deleteWtfButton.Visible = true;
                modifyWtfButton.Visible = true;
                startClientButton.Visible = true;
            }

            if (!RealmList.IsEmpty() && !WtfList.IsEmpty())
                realmEditButton.Visible = true;
            else
                realmEditButton.Visible = false;
        }

        private void checkNewRealmAddress()
        {
            if (wtfListComboBox.Items.Count == 0 || wtfListComboBox.Text == "")
            {
                newRealmAddressLabel.Text = "";
                addRealmbutton.Visible = false;
                return;
            }

            String selectedWtfLocation = WtfList.GetWtfLocation(wtfListComboBox.Text);

            String selectedWtfRealmListAddress = WtfList.GetRealmAddress(selectedWtfLocation);
            if (selectedWtfRealmListAddress != String.Empty)
            {
                String realmName = RealmList.GetRealmName(selectedWtfRealmListAddress);
                if (realmName != String.Empty)
                {
                    var i = 0;
                    foreach (String s in realmListComboBox.Items)
                    {
                        if (s == realmName)
                            break;
                        ++i;
                    }
                    realmListComboBox.SelectedIndex = i;
                    newRealmAddressLabel.Text = "";
                    addRealmbutton.Visible = false;
                }
                else
                {
                    newRealmAddressLabel.Text = selectedWtfRealmListAddress.Length > 64 ? selectedWtfRealmListAddress.Substring(0, 64) : selectedWtfRealmListAddress;
                    addRealmbutton.Visible = true;
                }
            }
        }

        private void cleanStatusMessage()
        {
            statusLabel.Text = "";
        }
        private void addStatusMessage(String message)
        {
            statusLabel.Text = message;
            statusMessageTimer.Stop(); // reset the timer
            statusMessageTimer.Start();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            XMLDataManager.LoadData();
            foreach (KeyValuePair<String, String> pair in RealmList.List)
                realmListComboBox.Items.Add(pair.Key);
            foreach (KeyValuePair<String, String> pair in WtfList.List)
                wtfListComboBox.Items.Add(pair.Key);
            checkListsEmpty();
            checkNewRealmAddress();

            if (!RealmList.IsEmpty())
                realmListComboBox.SelectedIndex = 0;
            if (!WtfList.IsEmpty())
                wtfListComboBox.SelectedIndex = 0;

            if (!RealmList.IsEmpty() || !WtfList.IsEmpty())
                addStatusMessage("data.xml loaded successfully.");
            else
                addStatusMessage("data.xml doesn't exist or it's empty.");
        }

        private void newRealmButton_Click(object sender, EventArgs e)
        {
            RealmDialog dialog = new RealmDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                RealmList.AddRealm(dialog.RealmName, dialog.RealmAddress);
                realmListComboBox.SelectedIndex = realmListComboBox.Items.Add(dialog.RealmName);
                checkListsEmpty();
                addStatusMessage("Realmlist added.");
            }
        }

        private void deleteRealmButton_Click(object sender, EventArgs e)
        {
            RealmList.DeleteRealm(realmListComboBox.Text);
            realmListComboBox.Items.Remove(realmListComboBox.Text);
            if (realmListComboBox.Items.Count > 0)
                realmListComboBox.SelectedIndex = 0;
            checkListsEmpty();
            checkNewRealmAddress();
            addStatusMessage("Realmlist deleted.");
        }

        private void modifyRealmButton_Click(object sender, EventArgs e)
        {
            String realmName = realmListComboBox.Text;
            String realmAddress = RealmList.GetRealmAddress(realmName);

            RealmDialog dialog = new RealmDialog(realmAddress, realmName);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (realmAddress != dialog.RealmAddress)
                {
                    RealmList.ModifyRealmAddress(realmName, dialog.RealmAddress);
                    selectedRealmAddressLabel.Text = dialog.RealmAddress;
                    checkNewRealmAddress();
                }
                if (realmName != dialog.RealmName)
                {
                    RealmList.ModifyRealmName(realmName, dialog.RealmName);

                    var i = 0;
                    foreach (String s in realmListComboBox.Items)
                    {
                        if (s == realmName)
                            break;
                        ++i;
                    }
                    realmListComboBox.Items.Remove(realmName);
                    realmListComboBox.SelectedIndex = realmListComboBox.Items.Add(dialog.RealmName);
                }
                addStatusMessage("Realmlist modified.");
            }
            checkListsEmpty();
        }

        private void newWtfButton_Click(object sender, EventArgs e)
        {
            WtfDialog dialog = new WtfDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                WtfList.AddWtf(dialog.WtfName, dialog.WtfLocation);
                wtfListComboBox.SelectedIndex = wtfListComboBox.Items.Add(dialog.WtfName);
                checkListsEmpty();
                addStatusMessage("WTF added.");
            }
        }

        private void deleteWtfButton_Click(object sender, EventArgs e)
        {
            WtfList.DeleteWtf(wtfListComboBox.Text);
            wtfListComboBox.Items.Remove(wtfListComboBox.Text);
            if (wtfListComboBox.Items.Count > 0)
                wtfListComboBox.SelectedIndex = 0;
            checkListsEmpty();
            checkNewRealmAddress();
            addStatusMessage("WTF deleted.");
        }

        private void modifyWtfButton_Click(object sender, EventArgs e)
        {
            String wtfName = wtfListComboBox.Text;
            String wtfLocation = WtfList.GetWtfLocation(wtfName);

            WtfDialog dialog = new WtfDialog(wtfLocation, wtfName);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (wtfLocation != dialog.WtfLocation)
                {
                    WtfList.ModifyWtfLocation(wtfName, dialog.WtfLocation);
                    selectedWtfLocationLabel.Text = dialog.WtfLocation;
                }
                if (wtfName != dialog.WtfName)
                {
                    WtfList.ModifyWtfName(wtfName, dialog.WtfName);

                    var i = 0;
                    foreach (String s in wtfListComboBox.Items)
                    {
                        if (s == wtfName)
                            break;
                        ++i;
                    }
                    wtfListComboBox.Items.Remove(wtfName);
                    wtfListComboBox.SelectedIndex = wtfListComboBox.Items.Add(dialog.WtfName);
                }
                addStatusMessage("WTF modified.");
            }
            checkListsEmpty();
            checkNewRealmAddress();
        }

        private void realmEditButton_Click(object sender, EventArgs e)
        {
            String realmlistWtfFile = WtfList.GetWtfLocation(wtfListComboBox.Text);
            if (!File.Exists(realmlistWtfFile))
            {
                MessageBox.Show(String.Format("This WTF doesn't exist!\n\n{0}", realmlistWtfFile), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool skipFirstLine = false;
            String[] originalFileLines = File.ReadAllLines(realmlistWtfFile);
            if (originalFileLines[0].Contains("set realmlist "))
                skipFirstLine = true;

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(realmlistWtfFile, false, Encoding.ASCII);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(String.Format("WTF file is not writable or readable!\n\n{0}", realmlistWtfFile), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            writer.WriteLine(String.Format("set realmlist {0}", RealmList.GetRealmAddress(realmListComboBox.Text)));
            for (var i = 0; i < originalFileLines.Length; ++i)
            {
                if (skipFirstLine && i == 0)
                    continue;
                writer.WriteLine(originalFileLines[i]);
            }
            writer.Close();
            checkNewRealmAddress();
            addStatusMessage("Realmlist.wtf modified.");
        }

        private void realmListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRealmAddressLabel.Text = RealmList.GetRealmAddress(realmListComboBox.Text);
        }
        private void wtfListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedWtfLocation = WtfList.GetWtfLocation(wtfListComboBox.Text);
            selectedWtfLocationLabel.Text = selectedWtfLocation;

            checkNewRealmAddress();
        }

        private void selectedWtfLocationLabel_TextChanged(object sender, EventArgs e)
        {
            clientPathToolTip.RemoveAll();

            if (selectedWtfLocationLabel.Text == String.Empty)
                return;

            String clientPath = WtfList.GetClientLocation(WtfList.GetWtfLocation(wtfListComboBox.Text));
            if (clientPath == String.Empty)
                startClientButton.Enabled = false;
            else
            {
                startClientButton.Enabled = true;
                clientPathToolTip.SetToolTip(startClientButton, clientPath);
            }
        }

        private void startClientButton_Click(object sender, EventArgs e)
        {
            String clientLocation = WtfList.GetClientLocation(WtfList.GetWtfLocation(wtfListComboBox.Text));
            System.Diagnostics.Process.Start(clientLocation);
            addStatusMessage(String.Format("{0} started.", clientLocation));
        }

        private void nevjegyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutDialog dialog = new AboutDialog();
            dialog.ShowDialog();
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addRealmbutton_Click(object sender, EventArgs e)
        {
            RealmDialog dialog = new RealmDialog(newRealmAddressLabel.Text, "");
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                RealmList.AddRealm(dialog.RealmName, dialog.RealmAddress);
                realmListComboBox.SelectedIndex = realmListComboBox.Items.Add(dialog.RealmName);
                checkListsEmpty();
                newRealmAddressLabel.Text = "";
                addRealmbutton.Visible = false;
                addStatusMessage("Realmlist added.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cleanStatusMessage();
        }
    }
}
