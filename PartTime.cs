using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class PartTime : Employee
    {
        public double rate { get; set; }
        public double hours { get; set; }

        public PartTime()
        {

        }

        public PartTime(string Aid, string Aname, string Aaddress, string Aphone, long Asin, string Adob, string Adept, double Arate, double Ahours)
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
            double totalpay;
            totalpay = this.hours * this.rate;
            return totalpay;
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
                   $"Emp Rate: {rate}\n" +
                   $"Emp Hours: {hours}\n" +
                   $"Emp Earnings: {Getpay()}\n"+
                   $"---------------------------------------------------";
        }
    }
}
