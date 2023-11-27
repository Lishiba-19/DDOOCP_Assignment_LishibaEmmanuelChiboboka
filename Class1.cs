using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DDOOCP_Assignment_LishibaEmmanuelChiboboka
{

    class User
    {

        public string username;
        public string password;

        public virtual Boolean checkPassword(string pass)
        {
            if (pass.ToLower().Equals(password.ToLower()))
            {
                return true;
            }
            return false;
        }


        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }


    }

    class Administrator : User
    {
        private int failedLogins;
        private Boolean locked;
        public int FailedLogins
        {
            get
            {
                return failedLogins;
            }
            set
            {
                failedLogins = value;
            }
        }
        public bool Locked
        {
            get
            {
                return locked;
            }
            set
            {
                locked = value;
            }
        }

        public override Boolean checkPassword(String pass)
        {
            Boolean retry;
            if (locked == true)
            {
                return false;
            }
            retry = base.checkPassword(pass);
            if (retry == false)
            {
                failedLogins += 1;
                if (failedLogins == 3)
                {
                    locked = true;
                }
                return false;
            }
            else
            {
                failedLogins = 0;
                return true;
            }
        }
    }

    class Consumer : User
    {

        public Consumer()
        { }

        public Consumer(string u, string p)
        {

            username = u;
            password = p;
        }
      }

    
}

