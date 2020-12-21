using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AssignmentFinal
{
    public class User
    {
        private string name;
        private string userName;
        private string email;
        private string password;
        private string dob;
        private string gender;
        private string bloodGroup;



        public User(string name, string userName, string email, string password, string dob, string gender, string bloodGroup)
        {
            this.name = name;
            this.userName = userName;
            this.email = email;
            this.password = password;
            this.dob = dob;
            this.gender = gender;
            this.bloodGroup = bloodGroup;
        }



        public string Name { get => name; set => name = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
        public string BloodGroup { get => bloodGroup; set => bloodGroup = value; }
    }
}
