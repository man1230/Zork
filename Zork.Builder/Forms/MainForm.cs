using System;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Zork;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        private bool IsGameLoaded
        {
            get
            {
                return _viewModel.IsGameLoaded;
            }
            set
            {
                _viewModel.IsGameLoaded = value;

                foreach (var control in _gameDependentControls)
                {
                    control.Enabled = _viewModel.IsGameLoaded;
                }

                foreach (var menuItem in _gameDependentMenuItems)
                {
                    menuItem.Enabled = _viewModel.IsGameLoaded;
                }
            }
        }
        private GameViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel != value)
                {
                    _viewModel = value;
                    gameViewModelBindingSource.DataSource = _viewModel;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();

            _gameDependentControls = new Control[]
            {
                roomsGroupBox,
                roomSettingsGroupBox,
                addRoomButton,
                deleteRoomButton
            };
            _gameDependentMenuItems = new ToolStripMenuItem[]
            {
                saveToolStripMenuItem,
                saveAsToolStripMenuItem
            };

            IsGameLoaded = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(openFileDialog.FileName);
                    ViewModel.Game = JsonConvert.DeserializeObject<Game>(jsonString);
                    IsGameLoaded = true;
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "TestFile.json";
            _viewModel.SaveWorld(filename);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room existingRoom = ViewModel.Rooms.FirstOrDefault(room => room.Name.Equals(addRoomForm.RoomName, StringComparison.OrdinalIgnoreCase));
                    if (existingRoom != null)
                    {
                        MessageBox.Show("Room already exists", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Room room = new Room(addRoomForm.RoomName);
                        ViewModel.Rooms.Add(room);
                    }
                }
            }
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.");
        }

        private GameViewModel _viewModel;
        private Control[] _gameDependentControls;
        private ToolStripMenuItem[] _gameDependentMenuItems;

    }
}
