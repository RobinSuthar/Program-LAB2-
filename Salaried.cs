using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Salaried: Employee
    {
        public double salary { get; set; }

        //public Salaried()
        //{
            //this.id = "";
            //this.name = "";
            //this.address = "";
            //this.phone = "";
            //this.sin = 0;
            //this.dept = "";

        //}

        public Salaried(string Aid, string Aname, string Aaddress, string Aphone, long Asin, string Adob, string Adept , double Asalary)
        {
            this.id = Aid;
            this.name = Aname;
            this.address = Aaddress;
            this.phone = Aphone;
            this.sin = Asin;
            this.dob = Adob;
            this.dept = Adept;
            this.salary = Asalary;
        }

        public double Getpay()
        {
            // These are supposed to be returned a specifcy salary which would be in the list
            return this.salary;
        }

        public override string ToString()
        {
            return $"Employee Details\n" +
                   $"ID: {id}\n" +
                   $"Name: {name}\n" +
                   $"Address: {address}\n" +
                   $"Phone Number : {phone}\n" +
                   $"Sin: {sin}\n" +
                   $"DOB: {dob}\n" +
                   $"Emp Department: {dept}\n" +
                   $"Emp Salary: {Getpay()} \n" + 
                   $"---------------------------------------------------";
        }
    }
}
