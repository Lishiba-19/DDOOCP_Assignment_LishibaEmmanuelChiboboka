using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDOOCP_Assignment_LishibaEmmanuelChiboboka
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void userControlCS_load(object sender, EventArgs e)
        {

        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void cmdCS_Click_1(object sender, EventArgs e)
        {

            UserControl2 CreateSur = new UserControl2();

            addUserControl(CreateSur);
        }

        private void cmdLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin f2 = new FormAdmin();
            f2.Show();

        }

        private void cmdAS_Click_1(object sender, EventArgs e)
        {

            UserControl1 ViewAnalysis = new UserControl1();

            addUserControl(ViewAnalysis);
        }

        private void cmdLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to log out?", "Info", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                this.Hide();
                FormAdmin fa = new FormAdmin();
                fa.Show();
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}

