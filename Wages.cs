using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Program
{
    internal class Wages : Employee
    {
        public double rate { get; set; }
        public double hours { get; set; }

        public Wages()
        {

        }

        public Wages(string Aid, string Aname, string Aaddress, string Aphone, long Asin, string Adob, string Adept, double Arate, double Ahours)
        {
            this.id = Aid;
            this.name = Aname;
            this.address = Aaddress;
            this.phone = Aphone;
            this.sin = Asin;
            this.dob = Adob;
            this.dept = Adept;
            this.rate = Arate;
            this.hours = Ahours;
        }

        public double Getpay()
        {
            if (this.hours > 40)
            {
                
                double ovetime = 1.5 * this.rate;
                return this.hours * ovetime;

                
            } else
            {
                
                return this.hours * this.rate;
            }
            
             
            
        }
        public override string ToString()
        {
            return $"WAGE EMPLOYEE: \n" +
                   $"Employee Details\n" +
                   $"ID: {id}\n" +
                   $"Name: {name}\n" +
                   $"Address: {address}\n" +
                   $"Phone Number : {phone}\n" +
                   $"Sin: {sin}\n" +
                   $"DOB: {dob}\n" +
                   $"Emp Department: {dept}\n" +
                   $"Emp Rate: {rate}\n" +
                   $"Emp Hours: {hours}\n" +
                   $"Emp Earnings: {Getpay()}\n" +
                   $"---------------------------------------------------";
        }
    }
}
