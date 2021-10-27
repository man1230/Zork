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
    }
}
