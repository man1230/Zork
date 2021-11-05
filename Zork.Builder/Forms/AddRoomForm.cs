using System.Windows.Forms;

namespace Zork.Builder
{
    public partial class AddRoomForm : Form
    {
        public string RoomName => nameTextBox.Text;

        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrWhiteSpace(RoomName);
        }
    }
}
