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

namespace RealmChanger
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.newRealmButton = new System.Windows.Forms.Button();
            this.realmListComboBox = new System.Windows.Forms.ComboBox();
            this.deleteRealmButton = new System.Windows.Forms.Button();
            this.modifyRealmButton = new System.Windows.Forms.Button();
            this.wtfListComboBox = new System.Windows.Forms.ComboBox();
            this.deleteWtfButton = new System.Windows.Forms.Button();
            this.modifyWtfButton = new System.Windows.Forms.Button();
            this.newWtfButton = new System.Windows.Forms.Button();
            this.realmEditButton = new System.Windows.Forms.Button();
            this.selectedRealmAddressLabel = new System.Windows.Forms.Label();
            this.selectedWtfLocationLabel = new System.Windows.Forms.Label();
            this.startClientButton = new System.Windows.Forms.Button();
            this.menuHelp = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.nevjegyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientPathToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.realmListGroupBox = new System.Windows.Forms.GroupBox();
            this.wtfGroupBox = new System.Windows.Forms.GroupBox();
            this.addRealmbutton = new System.Windows.Forms.Button();
            this.newRealmAddressLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusMessageTimer = new System.Windows.Forms.Timer(this.components);
            this.menuHelp.SuspendLayout();
            this.realmListGroupBox.SuspendLayout();
            this.wtfGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newRealmButton
            // 
            this.newRealmButton.Location = new System.Drawing.Point(192, 110);
            this.newRealmButton.Name = "newRealmButton";
            this.newRealmButton.Size = new System.Drawing.Size(72, 23);
            this.newRealmButton.TabIndex = 0;
            this.newRealmButton.Text = "New realm";
            this.newRealmButton.UseVisualStyleBackColor = true;
            this.newRealmButton.Click += new System.EventHandler(this.newRealmButton_Click);
            // 
            // realmListComboBox
            // 
            this.realmListComboBox.FormattingEnabled = true;
            this.realmListComboBox.Location = new System.Drawing.Point(20, 30);
            this.realmListComboBox.Name = "realmListComboBox";
            this.realmListComboBox.Size = new System.Drawing.Size(410, 21);
            this.realmListComboBox.Sorted = true;
            this.realmListComboBox.TabIndex = 1;
            this.realmListComboBox.SelectedIndexChanged += new System.EventHandler(this.realmListComboBox_SelectedIndexChanged);
            // 
            // deleteRealmButton
            // 
            this.deleteRealmButton.Location = new System.Drawing.Point(130, 82);
            this.deleteRealmButton.Name = "deleteRealmButton";
            this.deleteRealmButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRealmButton.TabIndex = 2;
            this.deleteRealmButton.Text = "Delete";
            this.deleteRealmButton.UseVisualStyleBackColor = true;
            this.deleteRealmButton.Click += new System.EventHandler(this.deleteRealmButton_Click);
            // 
            // modifyRealmButton
            // 
            this.modifyRealmButton.Location = new System.Drawing.Point(250, 82);
            this.modifyRealmButton.Name = "modifyRealmButton";
            this.modifyRealmButton.Size = new System.Drawing.Size(75, 23);
            this.modifyRealmButton.TabIndex = 3;
            this.modifyRealmButton.Text = "Modify";
            this.modifyRealmButton.UseVisualStyleBackColor = true;
            this.modifyRealmButton.Click += new System.EventHandler(this.modifyRealmButton_Click);
            // 
            // wtfListComboBox
            // 
            this.wtfListComboBox.DropDownWidth = 415;
            this.wtfListComboBox.FormattingEnabled = true;
            this.wtfListComboBox.Location = new System.Drawing.Point(20, 30);
            this.wtfListComboBox.Name = "wtfListComboBox";
            this.wtfListComboBox.Size = new System.Drawing.Size(410, 21);
            this.wtfListComboBox.Sorted = true;
            this.wtfListComboBox.TabIndex = 4;
            this.wtfListComboBox.SelectedIndexChanged += new System.EventHandler(this.wtfListComboBox_SelectedIndexChanged);
            // 
            // deleteWtfButton
            // 
            this.deleteWtfButton.Location = new System.Drawing.Point(130, 82);
            this.deleteWtfButton.Name = "deleteWtfButton";
            this.deleteWtfButton.Size = new System.Drawing.Size(75, 23);
            this.deleteWtfButton.TabIndex = 5;
            this.deleteWtfButton.Text = "Delete";
            this.deleteWtfButton.UseVisualStyleBackColor = true;
            this.deleteWtfButton.Click += new System.EventHandler(this.deleteWtfButton_Click);
            // 
            // modifyWtfButton
            // 
            this.modifyWtfButton.Location = new System.Drawing.Point(250, 82);
            this.modifyWtfButton.Name = "modifyWtfButton";
            this.modifyWtfButton.Size = new System.Drawing.Size(75, 23);
            this.modifyWtfButton.TabIndex = 6;
            this.modifyWtfButton.Text = "Modify";
            this.modifyWtfButton.UseVisualStyleBackColor = true;
            this.modifyWtfButton.Click += new System.EventHandler(this.modifyWtfButton_Click);
            // 
            // newWtfButton
            // 
            this.newWtfButton.Location = new System.Drawing.Point(192, 110);
            this.newWtfButton.Name = "newWtfButton";
            this.newWtfButton.Size = new System.Drawing.Size(75, 23);
            this.newWtfButton.TabIndex = 7;
            this.newWtfButton.Text = "New WTF";
            this.newWtfButton.UseVisualStyleBackColor = true;
            this.newWtfButton.Click += new System.EventHandler(this.newWtfButton_Click);
            // 
            // realmEditButton
            // 
            this.realmEditButton.Location = new System.Drawing.Point(460, 28);
            this.realmEditButton.Name = "realmEditButton";
            this.realmEditButton.Size = new System.Drawing.Size(114, 23);
            this.realmEditButton.TabIndex = 8;
            this.realmEditButton.Text = "Update realmlist.wtf";
            this.realmEditButton.UseVisualStyleBackColor = true;
            this.realmEditButton.Click += new System.EventHandler(this.realmEditButton_Click);
            // 
            // selectedRealmAddressLabel
            // 
            this.selectedRealmAddressLabel.AutoSize = true;
            this.selectedRealmAddressLabel.Location = new System.Drawing.Point(17, 54);
            this.selectedRealmAddressLabel.Name = "selectedRealmAddressLabel";
            this.selectedRealmAddressLabel.Size = new System.Drawing.Size(143, 13);
            this.selectedRealmAddressLabel.TabIndex = 9;
            this.selectedRealmAddressLabel.Text = "SelectedRealmAddressLabel";
            // 
            // selectedWtfLocationLabel
            // 
            this.selectedWtfLocationLabel.AutoSize = true;
            this.selectedWtfLocationLabel.Location = new System.Drawing.Point(17, 54);
            this.selectedWtfLocationLabel.Name = "selectedWtfLocationLabel";
            this.selectedWtfLocationLabel.Size = new System.Drawing.Size(133, 13);
            this.selectedWtfLocationLabel.TabIndex = 10;
            this.selectedWtfLocationLabel.Text = "SelectedWtfLocationLabel";
            this.selectedWtfLocationLabel.TextChanged += new System.EventHandler(this.selectedWtfLocationLabel_TextChanged);
            // 
            // startClientButton
            // 
            this.startClientButton.Location = new System.Drawing.Point(585, 28);
            this.startClientButton.Name = "startClientButton";
            this.startClientButton.Size = new System.Drawing.Size(92, 23);
            this.startClientButton.TabIndex = 11;
            this.startClientButton.Text = "Start WoW";
            this.startClientButton.UseVisualStyleBackColor = true;
            this.startClientButton.Click += new System.EventHandler(this.startClientButton_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem,
            this.menuAbout});
            this.menuHelp.Location = new System.Drawing.Point(0, 0);
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuHelp.Size = new System.Drawing.Size(724, 24);
            this.menuHelp.TabIndex = 12;
            this.menuHelp.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kilepesToolStripMenuItem});
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fajlToolStripMenuItem.Text = "File";
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.kilepesToolStripMenuItem.Text = "Exit";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nevjegyToolStripMenuItem1});
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(44, 20);
            this.menuAbout.Text = "Help";
            // 
            // nevjegyToolStripMenuItem1
            // 
            this.nevjegyToolStripMenuItem1.Name = "nevjegyToolStripMenuItem1";
            this.nevjegyToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.nevjegyToolStripMenuItem1.Text = "About";
            this.nevjegyToolStripMenuItem1.Click += new System.EventHandler(this.nevjegyToolStripMenuItem1_Click);
            // 
            // realmListGroupBox
            // 
            this.realmListGroupBox.Controls.Add(this.realmListComboBox);
            this.realmListGroupBox.Controls.Add(this.selectedRealmAddressLabel);
            this.realmListGroupBox.Controls.Add(this.deleteRealmButton);
            this.realmListGroupBox.Controls.Add(this.modifyRealmButton);
            this.realmListGroupBox.Controls.Add(this.newRealmButton);
            this.realmListGroupBox.Location = new System.Drawing.Point(15, 40);
            this.realmListGroupBox.Name = "realmListGroupBox";
            this.realmListGroupBox.Size = new System.Drawing.Size(690, 200);
            this.realmListGroupBox.TabIndex = 13;
            this.realmListGroupBox.TabStop = false;
            this.realmListGroupBox.Text = "RealmList";
            // 
            // wtfGroupBox
            // 
            this.wtfGroupBox.Controls.Add(this.addRealmbutton);
            this.wtfGroupBox.Controls.Add(this.newRealmAddressLabel);
            this.wtfGroupBox.Controls.Add(this.wtfListComboBox);
            this.wtfGroupBox.Controls.Add(this.selectedWtfLocationLabel);
            this.wtfGroupBox.Controls.Add(this.newWtfButton);
            this.wtfGroupBox.Controls.Add(this.startClientButton);
            this.wtfGroupBox.Controls.Add(this.modifyWtfButton);
            this.wtfGroupBox.Controls.Add(this.realmEditButton);
            this.wtfGroupBox.Controls.Add(this.deleteWtfButton);
            this.wtfGroupBox.Location = new System.Drawing.Point(15, 250);
            this.wtfGroupBox.Name = "wtfGroupBox";
            this.wtfGroupBox.Size = new System.Drawing.Size(690, 200);
            this.wtfGroupBox.TabIndex = 14;
            this.wtfGroupBox.TabStop = false;
            this.wtfGroupBox.Text = "WTF";
            // 
            // addRealmbutton
            // 
            this.addRealmbutton.Location = new System.Drawing.Point(20, 156);
            this.addRealmbutton.Name = "addRealmbutton";
            this.addRealmbutton.Size = new System.Drawing.Size(120, 23);
            this.addRealmbutton.TabIndex = 13;
            this.addRealmbutton.Text = "Add this realm";
            this.addRealmbutton.UseVisualStyleBackColor = true;
            this.addRealmbutton.Click += new System.EventHandler(this.addRealmbutton_Click);
            // 
            // newRealmAddressLabel
            // 
            this.newRealmAddressLabel.AutoSize = true;
            this.newRealmAddressLabel.Location = new System.Drawing.Point(17, 140);
            this.newRealmAddressLabel.Name = "newRealmAddressLabel";
            this.newRealmAddressLabel.Size = new System.Drawing.Size(123, 13);
            this.newRealmAddressLabel.TabIndex = 12;
            this.newRealmAddressLabel.Text = "NewRealmAddressLabel";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 453);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(63, 13);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "StatusLabel";
            // 
            // statusMessageTimer
            // 
            this.statusMessageTimer.Interval = 5000;
            this.statusMessageTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 472);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.wtfGroupBox);
            this.Controls.Add(this.realmListGroupBox);
            this.Controls.Add(this.menuHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealmChanger";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.menuHelp.ResumeLayout(false);
            this.menuHelp.PerformLayout();
            this.realmListGroupBox.ResumeLayout(false);
            this.realmListGroupBox.PerformLayout();
            this.wtfGroupBox.ResumeLayout(false);
            this.wtfGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newRealmButton;
        private System.Windows.Forms.ComboBox realmListComboBox;
        private System.Windows.Forms.Button deleteRealmButton;
        private System.Windows.Forms.Button modifyRealmButton;
        private System.Windows.Forms.ComboBox wtfListComboBox;
        private System.Windows.Forms.Button deleteWtfButton;
        private System.Windows.Forms.Button modifyWtfButton;
        private System.Windows.Forms.Button newWtfButton;
        private System.Windows.Forms.Button realmEditButton;
        private System.Windows.Forms.Label selectedRealmAddressLabel;
        private System.Windows.Forms.Label selectedWtfLocationLabel;
        private System.Windows.Forms.Button startClientButton;
        private System.Windows.Forms.MenuStrip menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem nevjegyToolStripMenuItem1;
        private System.Windows.Forms.ToolTip clientPathToolTip;
        private System.Windows.Forms.GroupBox realmListGroupBox;
        private System.Windows.Forms.GroupBox wtfGroupBox;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.Label newRealmAddressLabel;
        private System.Windows.Forms.Button addRealmbutton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer statusMessageTimer;

    }
}

