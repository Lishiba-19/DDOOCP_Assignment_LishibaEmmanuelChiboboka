using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DDOOCP_Assignment_LishibaEmmanuelChiboboka
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //Each of the radiobuttons are grouped in buttons depending on the question.
        //The button will store a radio button choice in the given file.
        //The following code is storing and updating the count in terms of how many times a choice has been selected.
        //This is mainly for analysis purposes.
        private void button13_Click(object sender, EventArgs e)
        {
            
            var filepath = "MainSurvey1.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();

            string r1 = "0", r2 = "0", r3 = "0", r4 = "0";
            if (radioButton1.Checked == true)
            {
                string num1 = lines[0];
                string num2 = "1";

                int result = int.Parse(num1) + int.Parse(num2);

                r1 = result.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(r1);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
            else if (radioButton2.Checked)
            {
                lines[1] = lines[1];
                string num2 = "1";

                int result = int.Parse(lines[1]) + int.Parse(num2);

                r2 = result.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(r2);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }

            else if (radioButton3.Checked)
            {
                lines[2] = lines[2];
                string num2 = "1";

                int result = int.Parse(lines[2]) + int.Parse(num2);

                r3 = result.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(r3);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }

            else if (radioButton4.Checked)
            {
                lines[3] = lines[3];
                string num2 = "1";

                int result = int.Parse(lines[3]) + int.Parse(num2);

                r4 = result.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(r4);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
               
            }
            else
            {
                MessageBox.Show("Unanswered ");
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            
            var filepath = "MainSurvey1.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();
            string r5 = "0", r6 = "0", r7 = "0", r8 = "0";
            if (radioButton5.Checked)
            {
                lines[4] = lines[4];
                string num = "1";

                int resul = int.Parse(lines[4]) + int.Parse(num);

                r5 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(r5);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
            else if (radioButton6.Checked)
            {
                lines[5] = lines[5];
                string num = "1";

                int resul = int.Parse(lines[5]) + int.Parse(num);

                r6 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(r6);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }

            else if (radioButton7.Checked)
            {
                lines[6] = lines[6];
                string num = "1";

                int resul = int.Parse(lines[6]) + int.Parse(num);

                r7 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(r7);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
            else if (radioButton8.Checked)
            {
                lines[7] = lines[7];
                string num = "1";

                int resul = int.Parse(lines[7]) + int.Parse(num);

                r8 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(r8);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }


        }
        private void button15_Click(object sender, EventArgs e)
        {
           
            var filepath = "MainSurvey1.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();
            string r9 = "0", r10 = "0", r11 = "0", r12 = "0", r13 = "0";
            if (radioButton9.Checked)
            {
                lines[8] = lines[8];
                string num = "1";

                int resul = int.Parse(lines[8]) + int.Parse(num);

                r9 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(r9);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
             else if (radioButton10.Checked)
            {
                lines[9] = lines[9];
                string num = "1";

                int resul = int.Parse(lines[9]) + int.Parse(num);

                r10 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(r10);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
            else if (radioButton11.Checked)
            {
                lines[10] = lines[10];
                string num = "1";

                int resul = int.Parse(lines[10]) + int.Parse(num);

                r11 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(r11);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
            else if (radioButton12.Checked)
            {
                lines[11] = lines[11];
                string num = "1";

                int resul = int.Parse(lines[11]) + int.Parse(num);

                r12 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(r12);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
            else if (radioButton13.Checked)
            {
                lines[12] = lines[12];
                string num = "1";

                int resul = int.Parse(lines[12]) + int.Parse(num);

                r13 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(r13);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            
            var filepath = "MainSurvey1.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();

            string r14 = "0", r15 = "0", r16 = "0";
            if (radioButton14.Checked)
            {
                lines[13] = lines[13];
                string num = "1";

                int resul = int.Parse(lines[13]) + int.Parse(num);

                r14 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(r14);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
            else if (radioButton15.Checked)
            {
                lines[14] = lines[14];
                string num = "1";

                int resul = int.Parse(lines[14]) + int.Parse(num);

                r15 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(r15);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
            else if (radioButton16.Checked)
            {
                lines[15] = lines[15];
                string num = "1";

                int resul = int.Parse(lines[15]) + int.Parse(num);

                r16 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(r16);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            var filepath = "MainSurvey1.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();

            string r17 = "0", r18 = "0", r19 = "0", r20 = "0";
            if (radioButton17.Checked)
            {
                lines[16] = lines[16];
                string num = "1";

                int resul = int.Parse(lines[16]) + int.Parse(num);

                r17 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(r17);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
            else if (radioButton18.Checked)
            {
                lines[17] = lines[17];
                string num = "1";

                int resul = int.Parse(lines[17]) + int.Parse(num);

                r18 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(r18);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
            else if (radioButton19.Checked)
            {
                lines[18] = lines[18];
                string num = "1";

                int resul = int.Parse(lines[18]) + int.Parse(num);

                r19 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(r19);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
            else if (radioButton20.Checked)
            {
                lines[19] = lines[19];
                string num = "1";

                int resul = int.Parse(lines[19]) + int.Parse(num);

                r20 = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(r20);
                    survey.WriteLine(lines[20]);
                    survey.WriteLine(lines[21]);
                    survey.Close();
                }
            }
        }

        //The submit is mainly dealing with the last question which deals with calculating the average result.
        private void cmdSubmit_Click_1(object sender, EventArgs e)
        {
       
                var filepath = "MainSurvey1.txt";
                List<string> lines = File.ReadAllLines(filepath).ToList();

                string num = label14.Text;

                label15.Text = lines[21];

                int result = int.Parse(lines[21]) + int.Parse("1");
                string count = result.ToString();

                int resul = ((int.Parse(lines[20]) + int.Parse(num)) / result);
                string av = resul.ToString();
                using (StreamWriter survey = new StreamWriter("MainSurvey1.txt"))
                {
                    survey.WriteLine(lines[0]);
                    survey.WriteLine(lines[1]);
                    survey.WriteLine(lines[2]);
                    survey.WriteLine(lines[3]);
                    survey.WriteLine(lines[4]);
                    survey.WriteLine(lines[5]);
                    survey.WriteLine(lines[6]);
                    survey.WriteLine(lines[7]);
                    survey.WriteLine(lines[8]);
                    survey.WriteLine(lines[9]);
                    survey.WriteLine(lines[10]);
                    survey.WriteLine(lines[11]);
                    survey.WriteLine(lines[12]);
                    survey.WriteLine(lines[13]);
                    survey.WriteLine(lines[14]);
                    survey.WriteLine(lines[15]);
                    survey.WriteLine(lines[16]);
                    survey.WriteLine(lines[17]);
                    survey.WriteLine(lines[18]);
                    survey.WriteLine(lines[19]);
                    survey.WriteLine(av);
                    survey.WriteLine(count);
                    survey.Close();
                }
                MessageBox.Show("Thanks for participating!", "Info");
            
        }    
        
        private void Form3_Load(object sender, EventArgs e)
        {
            var filepath = "MainSurvey1.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();
            label15.Text = lines[21];
         

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Verification to ensure the user wants to log out or not.
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to log out?", "Info", MessageBoxButtons.YesNo);

            if(response == DialogResult.Yes)
            {
                this.Hide();
                FormAdmin fa = new FormAdmin();
                fa.Show();
            }
            else
            {
                
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

            int num;
            num = 0;

            label14.Text = "" + num;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num;
            num = 1;

            label14.Text = "" + num;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num;
            num = 2;

            label14.Text = "" + num;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num;
            num = 3;

            label14.Text = "" + num;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num;
            num = 4;

            label14.Text = "" + num;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num;
            num = 5;

            label14.Text = "" + num;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num;
            num = 6;

            label14.Text = "" + num;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num;
            num = 7;

            label14.Text = "" + num;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int num;
            num = 8;

            label14.Text = "" + num;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int num;
            num = 9;

            label14.Text = "" + num;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int num;
            num = 10;

            label14.Text = "" + num;
        }
    }
}