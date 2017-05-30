using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DmxControlLib.Hardware;
using DmxControlLib.Utility;
using System.Diagnostics;

namespace Mapper
{
    public partial class MapperForm : Form
    {
        public LPMMap Map;

        public MapperForm()
        {
            InitializeComponent();
        }

        private void MapperForm_Load(object sender, EventArgs e)
        {
            LaunchPadControl.Connect();

            Map = new LPMMap("NewMapping");

            LaunchPadControl.LinkMapping(Map);

            foreach (buttonType item in Enum.GetValues(typeof(buttonType)))
            {
                comboBtType.Items.Add(item.ToString());
            }

            foreach(ButtonColor item in Enum.GetValues(typeof(ButtonColor)))
            {
                comboOncolor.Items.Add(item.ToString());
                comboOffcolor.Items.Add(item.ToString());
            }

            comboBoxID.SelectedItem = 0;
            comboOncolor.SelectedItem = "None";
            comboOffcolor.SelectedItem = "None";
            comboBtType.SelectedItem = "Momentary";

            radioClassBT.Checked = true;
        }

        private void radioClassBT_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxID.Items.Clear();
            foreach (DmxControlLib.Utility.Button obt in Map.BT)
            {
                comboBoxID.Items.Add(obt.ID);
            }
            comboBoxID.SelectedItem = 0;
        }

        private void radioSysBT_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxID.Items.Clear();
            foreach (DmxControlLib.Utility.Button oSysbt in Map.SysBT)
            {
                comboBoxID.Items.Add(oSysbt.ID);
            }
            comboBoxID.SelectedItem = 0;
        }

        private void MapperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LaunchPadControl.close();
        }

        private void ValidateBT_Click(object sender, EventArgs e)
        {
            int ind = 0;
            if(radioClassBT.Checked && !radioSysBT.Checked)
            {
                Debug.WriteLine(comboBoxID.SelectedItem.ToString());
                ind = Map.BT.FindIndex(x => x.ID == int.Parse(comboBoxID.SelectedItem.ToString()));
                switch(comboBtType.SelectedText)
                {
                    case "Momentary":
                        Map.BT[ind].Type = buttonType.Momentary;
                        break;

                    case "Toogle":
                        Map.BT[ind].Type = buttonType.Toogle;
                        break;

                    case "Temporized":
                        Map.BT[ind].Type = buttonType.Temporized;
                        break;
                }

                switch (comboOncolor.SelectedText)
                {
                    case "Green":
                        Map.BT[ind].onColor = ButtonColor.Green;
                        break;

                    case "Red":
                        Map.BT[ind].onColor = ButtonColor.Red;
                        break;

                    case "Ambre":
                        Map.BT[ind].onColor = ButtonColor.Ambre;
                        break;

                    case "Yellow":
                        Map.BT[ind].onColor = ButtonColor.Yellow;
                        break;

                    case "None":
                        Map.BT[ind].onColor = ButtonColor.None;
                        break;
                }

                switch (comboOncolor.SelectedText)
                {
                    case "Green":
                        Map.BT[ind].offColor = ButtonColor.Green;
                        break;

                    case "Red":
                        Map.BT[ind].offColor = ButtonColor.Red;
                        break;

                    case "Ambre":
                        Map.BT[ind].offColor = ButtonColor.Ambre;
                        break;

                    case "Yellow":
                        Map.BT[ind].offColor = ButtonColor.Yellow;
                        break;

                    case "None":
                        Map.BT[ind].offColor = ButtonColor.None;
                        break;
                }

                Map.BT[ind].onFlashing = checkBoxOnFlashing.Checked;
                Map.BT[ind].offFlashing = checkBoxOffFlashing.Checked;
            }
            else
            {
                ind = Map.SysBT.FindIndex(x => x.ID == int.Parse(comboBoxID.SelectedText));
                switch (comboBtType.SelectedText)
                {
                    case "Momentary":
                        Map.SysBT[ind].Type = buttonType.Momentary;
                        break;

                    case "Toogle":
                        Map.SysBT[ind].Type = buttonType.Toogle;
                        break;

                    case "Temporized":
                        Map.SysBT[ind].Type = buttonType.Temporized;
                        break;
                }

                switch (comboOncolor.SelectedText)
                {
                    case "Green":
                        Map.SysBT[ind].onColor = ButtonColor.Green;
                        break;

                    case "Red":
                        Map.SysBT[ind].onColor = ButtonColor.Red;
                        break;

                    case "Ambre":
                        Map.SysBT[ind].onColor = ButtonColor.Ambre;
                        break;

                    case "Yellow":
                        Map.SysBT[ind].onColor = ButtonColor.Yellow;
                        break;

                    case "None":
                        Map.SysBT[ind].onColor = ButtonColor.None;
                        break;
                }

                switch (comboOncolor.SelectedText)
                {
                    case "Green":
                        Map.SysBT[ind].offColor = ButtonColor.Green;
                        break;

                    case "Red":
                        Map.SysBT[ind].offColor = ButtonColor.Red;
                        break;

                    case "Ambre":
                        Map.SysBT[ind].offColor = ButtonColor.Ambre;
                        break;

                    case "Yellow":
                        Map.SysBT[ind].offColor = ButtonColor.Yellow;
                        break;

                    case "None":
                        Map.SysBT[ind].offColor = ButtonColor.None;
                        break;
                }

                Map.SysBT[ind].onFlashing = checkBoxOnFlashing.Checked;
                Map.SysBT[ind].offFlashing = checkBoxOffFlashing.Checked;
            }

            LaunchPadControl.LinkMapping(Map);
        }
    }
}
