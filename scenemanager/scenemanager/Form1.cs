using scenemanager.IDS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scenemanager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textureidlist.DataSource = Enum.GetValues(typeof(IDS.TextureIds));
            objectidlist.DataSource = Enum.GetValues(typeof(IDS.ItemID));
            actionlist.DataSource = Enum.GetValues(typeof(Types.OnClickAction));
            globaldata.Init();
        }

        private void scenename_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(scenename, "scenename inputfield");
        }

        private void sceneid_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(sceneid, "sceneid inputfield");
        }

        private void screenposition_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(screenposition, "screenposition inputfield int[2] x,y");
        }

        private void screensize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(screensize, "screensize inputfield int[2] h,w");
        }

        private void append_Click(object sender, EventArgs e)
        {
            if (screenposition.Text.Split().Length < 2 || screensize.Text.Split().Length < 2)
            {
                MessageBox.Show("Invalid input format for screen position or size.");
                return;
            }

            Types.GameObjectData data = new Types.GameObjectData
            {
                textureid = (IDS.TextureIds)textureidlist.SelectedItem,
                objectid = (IDS.ItemID)objectidlist.SelectedItem,
                clickable = clickable.Checked,
                screencords = new Types.Rect(
                int.Parse(screenposition.Text.Split()[0]),
                int.Parse(screenposition.Text.Split()[1]),
                int.Parse(screensize.Text.Split()[0]),
                int.Parse(screensize.Text.Split()[1])
                ),
                onClickAction = (Types.OnClickAction)actionlist.SelectedItem,
                arguments = arguments.Text
            };

            globaldata.Append(data);
        }

        private void arguments_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(arguments, "custom args");
        }

        private void wipe_Click(object sender, EventArgs e)
        {
            globaldata.gameobjectbuffer.Clear();
        }

        private void sceneid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void screenposition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void screensize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            globaldata.load();
        }

        private void save_Click(object sender, EventArgs e)
        {
            globaldata.save();
        }

        private void backgroundimg_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(arguments, "background img name (example.png)");
        }

        private void viewjson_Click(object sender, EventArgs e)
        {
            globaldata.open();
        }

        private void refreshcache_Click(object sender, EventArgs e)
        {
            //equivalent is load()
        }
    }
}
