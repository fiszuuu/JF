using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_dealers
{
    public partial class Form1 : Form
    {
        string[] employees = new string[]{"Hamilton, David", "Hensien, Kari",
            "Hammond, Maria", "Harris, Keith", "Henshaw, Jeff D.",
            "Hanson, Mark", "Harnpadoungsataya, Sariya",
            "Harrington, Mark", "Harris, Keith", "Hartwig, Doris",
            "Harui, Roger", "Hassall, Mark", "Hasselberg, Jonas",
            "Harnpadoungsataya, Sariya", "Henshaw, Jeff D.",
            "Henshaw, Jeff D.", "Hensien, Kari", "Harris, Keith",
            "Henshaw, Jeff D.", "Hensien, Kari", "Hasselberg, Jonas",
            "Harrington, Mark", "Hedlund, Magnus", "Hay, Jeff",
            "Heidepriem, Brandon D."};
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        private void InitializeComboBox()
        {


            comboBox1.Items.AddRange(employees);

            // Associate the event-handling method with the 
            // SelectedIndexChanged event.
            //this.comboBox1.SelectedIndexChanged +=
            //    new System.EventHandler(comboBox1_SelectedIndexChanged);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = employees[comboBox1.SelectedIndex];
        }
    }
}
