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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void FormSur_Load(object sender, EventArgs e)
        {
  
        }
        //This will allow users to be directed to the log in form.
        private void cmdLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin f2 = new FormAdmin();

            f2.Show();
        }

        //The sign up button is responsible for storing new users into the system.
        private void cmdSignUp_Click_1(object sender, EventArgs e)
        {
          Consumer c;
          c = new Consumer(txtUsername.Text, txtPass.Text);

          c.Username = txtUsername.Text;
          c.Password = txtPass.Text;
            if (txtUsername.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please make sure you put both username and password.", "Info");
            }
            else if (c.Password == txtRe.Text)
            {
                using (StreamWriter A = new StreamWriter("Userdetails.txt", true))
                {
                    A.WriteLine(c.Username + " " + c.Password);
                    A.Close();
                    MessageBox.Show("Account has been created.", "Info");

                    this.Hide();
                    Form3 f3 = new Form3();

                    f3.Show();
                }
            }
            else
            {
                MessageBox.Show("Password may not much with the verifying input.");
            }
        }

    }
}
