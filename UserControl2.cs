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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }


        private void cmdDB_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();

            f4.Show();
        }

        //The function below will create a new file and store the admins questions in that particular file.
        private void cmdSubmit_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a name for your survey.");
            }

            else if (File.Exists(txtName.Text))
            {
                MessageBox.Show("This survey already exists.");
                txtName.Text = "";
                label11.Text = "";
            }

            else
            {
                //This will save the admins' questions in a file

                StreamWriter writerS;
                writerS = File.CreateText(txtName.Text+".txt");
                //Q1
                string d1 = textBox19.Text;
                string d2 = textBox7.Text;
                string d3 = textBox8.Text;
                string d4 = textBox9.Text;
                //Q2
                string d5 = textBox2.Text;
                string d6 = textBox10.Text;
                string d7 = textBox11.Text;
                string d8 = textBox12.Text;
                //Q3
                string d9 = textBox3.Text;
                //Q4
                string d10 = textBox4.Text;
                //Q5
                string d11 = textBox5.Text;
                string d12 = textBox13.Text;
                string d13 = textBox14.Text;
                string d14 = textBox15.Text;
                //Q6
                string d15 = textBox6.Text;
                string d16 = textBox16.Text;
                string d17 = textBox17.Text;
                string d18 = textBox18.Text;
                string d19 = txtName.Text;

                //Q1
                writerS.WriteLine(d1);
                writerS.WriteLine(d2);
                writerS.WriteLine(d3);
                writerS.WriteLine(d4);
                //Q2
                writerS.WriteLine(d5);
                writerS.WriteLine(d6);
                writerS.WriteLine(d7);
                writerS.WriteLine(d8);
                //Q3
                writerS.WriteLine(d9);
                //Q4
                writerS.WriteLine(d10);
                //Q5
                writerS.WriteLine(d11);
                writerS.WriteLine(d12);
                writerS.WriteLine(d13);
                writerS.WriteLine(d14);
                //Q6
                writerS.WriteLine(d15);
                writerS.WriteLine(d16);
                writerS.WriteLine(d17);
                writerS.WriteLine(d18);
                writerS.WriteLine(d19);
                writerS.Close();

                MessageBox.Show("Survey created.");
            }

     
            foreach (Control t in groupBox1.Controls)
            {
                if (t is TextBox)
                {
                    t.Text = "";
                }
            }
        }
        //This will allow the admin to selected the file in which they stored their questions and display them.
        private void cmdView_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filepath = (openFileDialog1.FileName);
                List<string> lines = File.ReadAllLines(filepath).ToList();
               
                foreach (string line in lines)
                {//question 1
                  
                    textBox19.Text = lines[0];
                    textBox7.Text = lines[1];
                    textBox8.Text = lines[2];
                    textBox9.Text = lines[3];
                    //question 2 
                    textBox2.Text = lines[4];
                    textBox10.Text = lines[5];
                    textBox11.Text = lines[6];
                    textBox12.Text = lines[7];
                    //question 3
                    textBox3.Text = lines[8];
                    //question 4
                    textBox4.Text = lines[9];
                    //question 5
                    textBox5.Text = lines[10];
                    textBox13.Text = lines[11];
                    textBox14.Text = lines[12];
                    textBox15.Text = lines[13];
                    //question 6
                    textBox6.Text = lines[14];
                    textBox16.Text = lines[15];
                    textBox17.Text = lines[16];
                    textBox18.Text = lines[17];
                    label11.Text = lines[18];
                }
            }


        }

      
    }

}

