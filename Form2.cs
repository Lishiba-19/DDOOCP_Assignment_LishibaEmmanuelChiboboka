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
    public partial class FormAdmin : Form
    {
        List<Administrator> Admins;
        public FormAdmin()
        {
            InitializeComponent();
        }



        //Method for adding accounts
        private void addAccount(string Adminuser, string pass)
        {
            Administrator a;
            a = new Administrator();

            a.Username = Adminuser;
            a.Password = pass;
            Admins.Add(a);
        }

        private void FormAdmin_Load_1(object sender, EventArgs e)
        {
            Admins = new List<Administrator>();

            addAccount("Steven", "1stivo");
            addAccount("Dalitso", "dee123");
            addAccount("Frank", "password");
            addAccount("Joy", "123456");
            addAccount("admin", "123");
        }

        //Method used to check the curent administrtor logging in.
        private Administrator checkAdministrator(string tt)
        {
            for (int i = 0; i < Admins.Count; i++)
            {
                if (Admins[i].Username.ToLower() == tt.ToLower())
                {
                    return Admins[i];
                }
            }
            return null;
        }


        private void cmdBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            FormSignUp f1 = new FormSignUp();

            f1.Show();
        }

        //The timer will be activated once an admin has failed to log in too many times.
        //When the time elapses, the log in button will be enabled but that particular admin will be temporarily locked out.
        private int _ticks;
        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            label4.Text = "Please wait 15 seconds " + _ticks.ToString() + ".";
            if (_ticks == 15)
            {
                cmdLogin.Enabled = true;
                timer1.Stop();
                _ticks = 0;
                label4.Text = "";
            }
        }

        //Admin login and validation
        private void cmdLogin_Click_1(object sender, EventArgs e)
        {
            Administrator Admin;
            Admin = checkAdministrator(txtAUsername.Text);
           
            if (Admin == null)
            {
                MessageBox.Show("No such account.", "Info");
                return;
            }

            if (Admin.checkPassword(txtPassword.Text))
            {
                MessageBox.Show("Access granted.", "Info");
                this.Hide();
                Form4 f4 = new Form4();

                f4.Show();
            }

            else if(Admin.FailedLogins == 3)
            {
                timer1.Start();
                cmdLogin.Enabled = false;
                MessageBox.Show("You have put an incorrect password too many times! Account is locked temporarily ", "Oops!" );
            }
            else
            {
                MessageBox.Show("Access Denied.", "Info");
            }
        }

        //User login and validation
        private void cusLog_Click_1(object sender, EventArgs e)
        {
            string filepath = "Userdetails.txt";
            List<string> Users = File.ReadAllLines(filepath).ToList();

            foreach (string user in Users)
            {
                if (File.Exists("Userdetails.txt") && user == txtUsername.Text + " " + txtPassword.Text)
                {
                    MessageBox.Show("Access granted", "Info");
                    Form3 f3 = new Form3();

                    f3.Show();
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                    this.Hide();
                }

                else
                {
                    errorProvider1.SetError(txtUsername, "Wrong username or password");
                    errorProvider2.SetError(txtPassword, "Wrong username or password");
                }


            }
        }

    
    }

}
