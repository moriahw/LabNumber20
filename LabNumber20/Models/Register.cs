using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabNumber20.Models
{
    public class RegisterModel
    {
        private string firstname;
        private string lastname;
        private string email;
        private string phonenumber;
        private string password;

        public string Firstname
        {
            set { firstname = value; }
            get { return firstname; }
        }

        public string Lastname
        {
            set { lastname = value;}
            get { return lastname; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public string Phonenumber
        {
            set { phonenumber = value; }
            get { return phonenumber; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }

        public RegisterModel()
        {
            Firstname = "";
            Lastname = "";
            Email = "";
            Phonenumber = "";
            Password = "";
        }

        public RegisterModel(string fn, string ln, string e, string pn, string pw)
        {
            Firstname = fn;
            Lastname = ln;
            Email = e;
            Phonenumber = pn;
            Password = pw;
        }
      
            
    }
}