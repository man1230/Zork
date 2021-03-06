
namespace Zork.Builder
{
    partial class MainForm
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
            System.Windows.Forms.MenuStrip mainMenuStrip;
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator fileSeparatorStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.roomsTabPage = new System.Windows.Forms.TabPage();
            this.roomSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.neighborsGroupBox = new System.Windows.Forms.GroupBox();
            this.southSelectNeighborControl = new Zork.Builder.UserControls.SelectNeighborControl();
            this.westSelectNeighborControl = new Zork.Builder.UserControls.SelectNeighborControl();
            this.eastSelectNeighborControl = new Zork.Builder.UserControls.SelectNeighborControl();
            this.northSelectNeighborControl = new Zork.Builder.UserControls.SelectNeighborControl();
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.roomsGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.gameSettingsTabPage = new System.Windows.Forms.TabPage();
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fileSeparatorStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.roomsTabPage.SuspendLayout();
            this.roomSettingsGroupBox.SuspendLayout();
            this.neighborsGroupBox.SuspendLayout();
            this.roomsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem});
            mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new System.Drawing.Size(583, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newToolStripMenuItem,
            openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            fileSeparatorStripMenuItem,
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // fileSeparatorStripMenuItem
            // 
            fileSeparatorStripMenuItem.Name = "fileSeparatorStripMenuItem";
            fileSeparatorStripMenuItem.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.AllowNew = true;
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.GameViewModel);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.roomsTabPage);
            this.mainTabControl.Controls.Add(this.gameSettingsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(583, 356);
            this.mainTabControl.TabIndex = 1;
            // 
            // roomsTabPage
            // 
            this.roomsTabPage.Controls.Add(this.roomSettingsGroupBox);
            this.roomsTabPage.Controls.Add(this.roomsGroupBox);
            this.roomsTabPage.Location = new System.Drawing.Point(4, 22);
            this.roomsTabPage.Name = "roomsTabPage";
            this.roomsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.roomsTabPage.Size = new System.Drawing.Size(575, 330);
            this.roomsTabPage.TabIndex = 0;
            this.roomsTabPage.Text = "Rooms";
            this.roomsTabPage.UseVisualStyleBackColor = true;
            // 
            // roomSettingsGroupBox
            // 
            this.roomSettingsGroupBox.Controls.Add(this.neighborsGroupBox);
            this.roomSettingsGroupBox.Controls.Add(this.roomDescriptionTextBox);
            this.roomSettingsGroupBox.Controls.Add(this.roomDescriptionLabel);
            this.roomSettingsGroupBox.Controls.Add(this.nameTextBox);
            this.roomSettingsGroupBox.Controls.Add(this.roomNameLabel);
            this.roomSettingsGroupBox.Location = new System.Drawing.Point(214, 6);
            this.roomSettingsGroupBox.Name = "roomSettingsGroupBox";
            this.roomSettingsGroupBox.Size = new System.Drawing.Size(354, 319);
            this.roomSettingsGroupBox.TabIndex = 4;
            this.roomSettingsGroupBox.TabStop = false;
            this.roomSettingsGroupBox.Text = "Room Settings";
            // 
            // neighborsGroupBox
            // 
            this.neighborsGroupBox.Controls.Add(this.southSelectNeighborControl);
            this.neighborsGroupBox.Controls.Add(this.westSelectNeighborControl);
            this.neighborsGroupBox.Controls.Add(this.eastSelectNeighborControl);
            this.neighborsGroupBox.Controls.Add(this.northSelectNeighborControl);
            this.neighborsGroupBox.Location = new System.Drawing.Point(10, 106);
            this.neighborsGroupBox.Name = "neighborsGroupBox";
            this.neighborsGroupBox.Size = new System.Drawing.Size(338, 207);
            this.neighborsGroupBox.TabIndex = 4;
            this.neighborsGroupBox.TabStop = false;
            this.neighborsGroupBox.Text = "Neighbors";
            // 
            // southSelectNeighborControl
            // 
            this.southSelectNeighborControl.Direction = Zork.Directions.SOUTH;
            this.southSelectNeighborControl.Location = new System.Drawing.Point(83, 141);
            this.southSelectNeighborControl.Name = "southSelectNeighborControl";
            this.southSelectNeighborControl.Neighbor = null;
            this.southSelectNeighborControl.Room = null;
            this.southSelectNeighborControl.Size = new System.Drawing.Size(152, 55);
            this.southSelectNeighborControl.TabIndex = 3;
            // 
            // westSelectNeighborControl
            // 
            this.westSelectNeighborControl.Direction = Zork.Directions.WEST;
            this.westSelectNeighborControl.Location = new System.Drawing.Point(-14, 80);
            this.westSelectNeighborControl.Name = "westSelectNeighborControl";
            this.westSelectNeighborControl.Neighbor = null;
            this.westSelectNeighborControl.Room = null;
            this.westSelectNeighborControl.Size = new System.Drawing.Size(152, 55);
            this.westSelectNeighborControl.TabIndex = 2;
            // 
            // eastSelectNeighborControl
            // 
            this.eastSelectNeighborControl.Direction = Zork.Directions.EAST;
            this.eastSelectNeighborControl.Location = new System.Drawing.Point(180, 80);
            this.eastSelectNeighborControl.Name = "eastSelectNeighborControl";
            this.eastSelectNeighborControl.Neighbor = null;
            this.eastSelectNeighborControl.Room = null;
            this.eastSelectNeighborControl.Size = new System.Drawing.Size(152, 55);
            this.eastSelectNeighborControl.TabIndex = 1;
            // 
            // northSelectNeighborControl
            // 
            this.northSelectNeighborControl.Direction = Zork.Directions.NORTH;
            this.northSelectNeighborControl.Location = new System.Drawing.Point(83, 19);
            this.northSelectNeighborControl.Name = "northSelectNeighborControl";
            this.northSelectNeighborControl.Neighbor = null;
            this.northSelectNeighborControl.Room = null;
            this.northSelectNeighborControl.Size = new System.Drawing.Size(152, 55);
            this.northSelectNeighborControl.TabIndex = 0;
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(10, 80);
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(302, 20);
            this.roomDescriptionTextBox.TabIndex = 3;
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.AutoSize = true;
            this.roomDescriptionLabel.Location = new System.Drawing.Point(10, 64);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.roomDescriptionLabel.TabIndex = 2;
            this.roomDescriptionLabel.Text = "Description";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameTextBox.Location = new System.Drawing.Point(10, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(302, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(7, 20);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(35, 13);
            this.roomNameLabel.TabIndex = 0;
            this.roomNameLabel.Text = "Name";
            // 
            // roomsGroupBox
            // 
            this.roomsGroupBox.Controls.Add(this.deleteRoomButton);
            this.roomsGroupBox.Controls.Add(this.roomsListBox);
            this.roomsGroupBox.Controls.Add(this.addRoomButton);
            this.roomsGroupBox.Location = new System.Drawing.Point(8, 6);
            this.roomsGroupBox.Name = "roomsGroupBox";
            this.roomsGroupBox.Size = new System.Drawing.Size(200, 319);
            this.roomsGroupBox.TabIndex = 3;
            this.roomsGroupBox.TabStop = false;
            this.roomsGroupBox.Text = "Rooms";
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Enabled = false;
            this.deleteRoomButton.Location = new System.Drawing.Point(119, 290);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRoomButton.TabIndex = 3;
            this.deleteRoomButton.Text = "&Delete";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.deleteRoomButton_Click);
            // 
            // roomsListBox
            // 
            this.roomsListBox.DataSource = this.roomsBindingSource;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(7, 20);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(187, 264);
            this.roomsListBox.TabIndex = 1;
            this.roomsListBox.ValueMember = "Description";
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.roomsListBox_SelectedIndexChanged);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(38, 290);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 2;
            this.addRoomButton.Text = "&Add";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // gameSettingsTabPage
            // 
            this.gameSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.gameSettingsTabPage.Name = "gameSettingsTabPage";
            this.gameSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gameSettingsTabPage.Size = new System.Drawing.Size(575, 330);
            this.gameSettingsTabPage.TabIndex = 1;
            this.gameSettingsTabPage.Text = "Game Settings";
            this.gameSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 380);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.roomsTabPage.ResumeLayout(false);
            this.roomSettingsGroupBox.ResumeLayout(false);
            this.roomSettingsGroupBox.PerformLayout();
            this.neighborsGroupBox.ResumeLayout(false);
            this.roomsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage roomsTabPage;
        private System.Windows.Forms.GroupBox roomSettingsGroupBox;
        private System.Windows.Forms.TextBox roomDescriptionTextBox;
        private System.Windows.Forms.Label roomDescriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.GroupBox roomsGroupBox;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.TabPage gameSettingsTabPage;
        private System.Windows.Forms.GroupBox neighborsGroupBox;
        private UserControls.SelectNeighborControl southSelectNeighborControl;
        private UserControls.SelectNeighborControl westSelectNeighborControl;
        private UserControls.SelectNeighborControl eastSelectNeighborControl;
        private UserControls.SelectNeighborControl northSelectNeighborControl;
    }
}

