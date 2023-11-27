using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DDOOCP_Assignment_LishibaEmmanuelChiboboka
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private void cmdVR_Click(object sender, EventArgs e)
        {
            //This code below will read the given text file and diplay its content in the specified labels.
            string filepath = "MainSurvey1.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();

            label22.Text = lines[0];
            label23.Text = lines[1];
            label24.Text = lines[2];
            label25.Text = lines[3];
            label26.Text = lines[4];
            label27.Text = lines[5];
            label28.Text = lines[6];
            label29.Text = lines[7];
            label30.Text = lines[8];
            label31.Text = lines[9];
            label32.Text = lines[10];
            label33.Text = lines[11];
            label34.Text = lines[12];
            label35.Text = lines[13];
            label36.Text = lines[14];
            label37.Text = lines[15];
            label38.Text = "0";
            label39.Text = lines[16];
            label40.Text = lines[17];
            label41.Text = lines[18];
            label42.Text = lines[19];
            label43.Text = lines[20];

        }
    }
}
