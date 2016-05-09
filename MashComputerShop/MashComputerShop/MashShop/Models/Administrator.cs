using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashComputerShop.MashShop.Models
{
    public class Administrator : User
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public int AdminID { get { return UserID; } set { UserID = value; } }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // let's pretend that this doesn't exist
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public byte[] ProfileImage { get; set; }

        public string JMBG { get; set; }
        public Decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        // Konstruktor
        public Administrator(int id = 0) : base(id)
        {
            FirstName = "Jon"; LastName = "Doe";
            Username = ""; Password = "";
            Email = ""; TelephoneNumber = "";
            ProfileImage = null;
            JMBG = ""; Salary = 0; HireDate = DateTime.Today;
        }

        public Administrator(int id, string firstName, string lastName, string jmbg, DateTime hireDate, Decimal salary,
            string usrName, string pw, string email, string telNumber) : base(id)
        {
            AdminID = id;
            FirstName = firstName; LastName = lastName; JMBG = jmbg;
            Username = usrName; Password = pw;
            Salary = salary;
            Email = email;
            TelephoneNumber = telNumber;
            ProfileImage = null;
        }
    }
}
