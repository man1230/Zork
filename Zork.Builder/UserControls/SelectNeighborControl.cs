using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zork.Builder.UserControls
{
    public partial class SelectNeighborControl : UserControl
    {
        public static readonly Room NoNeighbor = new Room() { Name = "None" };

        public Room Room
        {
            get => mRoom;
            set
            {
                if (mRoom != value)
                {
                    mRoom = value;
                    if (Room != null)
                    {
                        var rooms = new List<Room>(mRoom.Neighbors.Values);
                        rooms.Insert(0, NoNeighbor);
                        neighborsComboBox.SelectedIndexChanged -= neighborsComboBox_SelectedIndexChanged;
                        neighborsComboBox.DataSource = rooms;

                        if (mRoom.Neighbors.TryGetValue(Direction, out Room neighbor))
                        {
                            Neighbor = neighbor;
                        }
                        else
                        {
                            neighbor = NoNeighbor;
                        }
                        neighborsComboBox.SelectedIndexChanged += neighborsComboBox_SelectedIndexChanged;
                    }
                    else
                    {
                        neighborsComboBox.DataSource = null;
                    }
                }
            }
        }
        public SelectNeighborControl()
        {
            InitializeComponent();
        }

        public Directions Direction
        {
            get => mDirection;
            set
            {
                mDirection = value;
                directionTextBox.Text = value.ToString();
            }
        }

        public Room Neighbor
        {
            get => (Room)neighborsComboBox.SelectedItem;
            set => neighborsComboBox.SelectedItem = value;
        }

        private void neighborsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mRoom != null)
            {
                Room selectedRoom = (Room)neighborsComboBox.SelectedItem;
                if (selectedRoom == NoNeighbor)
                {
                    mRoom.Neighbors.Remove(Direction);
                }
                else
                {
                    mRoom.Neighbors[Direction] = selectedRoom;
                }
            }
        }

        private Room mRoom;
        private Directions mDirection;

    }
}