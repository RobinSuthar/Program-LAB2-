using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Employee
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public long sin { get; set; }
        public string dob { get; set; }
        public string dept { get; set; }

        public Employee() 
        {
            this.id = "";
            this.name = "";
            this.address = "";
            this.phone = "";
            this.sin = 0;
            this.dept = "";

        }

        public Employee(string Aid,string Aname, string Aaddress, string Aphone, long Asin, string Adob, string Adept)
        {
            this.id = Aid;
            this.name = Aname;
            this.address = Aaddress;
            this.phone = Aphone;
            this.sin = Asin;
            this.dob = Adob;
            this.dept = Adept;
        }


        public override string ToString()
        {
        return    $"Employee Details\n" +
                   $"ID: {id}\n" +
                   $"Name: {name}\n" +
                   $"Address: {address}\n" +
                   $"Phone Number : {phone}\n" +
                   $"Sin: {sin}\n" +
                   $"DOB: {dob}\n" +
                   $"Emp Department: {dept}\n" +
                   $"---------------------------------------------------";
        }


    }
}
