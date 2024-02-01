using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Program
{
    internal class Program : Employee
    {
        static void Main(string[] args)
        {
            //READING AND WRITNG THE TXT FILE.
            string filePath = @"C:\Users\robin\source\repos\Program\Properties\employees.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            //Using some variable to solve the problems
            double avgSal = 0;
            double avgpartime = 0;
            double avgwage = 0;
            double higehstpayofwageemp=0;
            string higestpayempname = "";
            string lowestsalname = "";
            double lowestsal = double.MaxValue;
            double s = 0;
            double w = 0;
            double p = 0;

            //Looping through each line of text file and using its data 
            foreach (string line2 in lines)
            {

                //Spliting the text text so to able to use its data
                string[] parts = line2.Split(':');
                string empId = parts[0];
                string empName = parts[1];
                string empAddress = parts[2];
                string empPhoneNumber = parts[3];
                long empSSN = long.Parse(parts[4]);
                string empDOB = parts[5];
                string empDepartment = parts[6];

                //Using if same of decide the category of the employee
               if (line2.StartsWith("0") || line2.StartsWith("1") || line2.StartsWith("2") || line2.StartsWith("3") || line2.StartsWith("4"))
               {
                    
                    s++;
                    //Dispalying the desired outocome
                    string empSalary = parts[7];
                    double result = double.Parse(empSalary);
                    Salaried sal1 = new Salaried(empId, empName, empAddress, empPhoneNumber, empSSN, empDOB, empDepartment, result);
                    Console.WriteLine("SALARY ACCOUNT: ");
                    Console.WriteLine(sal1);
                    
                    //ading the salary of each employee into avgSal to find the average weelkly salary of all the employees
                    avgSal += result;

                    //This is to calculate the lowest salary
                    if (result < lowestsal)
                    {
                        lowestsal = result;
                        lowestsalname = sal1.name;
                    }

               }
               if (line2.StartsWith("5") || line2.StartsWith("6") || line2.StartsWith("7"))
               {
                    w++;
                    //Dispalying the desired outocome
                    string empRate = parts[7];
                    double empfinalrate = double.Parse(empRate);
                    string empHours = parts[8];
                    double empfinalhours = double.Parse(empHours);
                    double finalpayr = empfinalrate * empfinalhours;
                    Wages wages1 = new Wages(empId, empName, empAddress, empPhoneNumber, empSSN, empDOB, empDepartment, empfinalrate, empfinalhours);
                    Console.WriteLine(wages1);
                    avgwage += wages1.Getpay();

                    //This is to calculate the highest salary
                    higehstpayofwageemp = wages1.Getpay();
                    if (finalpayr < wages1.Getpay())
                    {
                        higehstpayofwageemp = wages1.Getpay();
                        higestpayempname = wages1.name;
                    }

               }
               if (line2.StartsWith("8") || line2.StartsWith("9"))
               {
                    p++;
                    //Dispalying the desired outocome
                    string empRate = parts[7];
                    double empfinalrate = double.Parse(empRate);
                    string empHours = parts[8];
                    double empfinalhours = double.Parse(empHours);
                    PartTime partime1 = new PartTime(empId, empName, empAddress, empPhoneNumber, empSSN, empDOB, empDepartment, empfinalrate, empfinalhours);
                    Console.WriteLine("PART TIME EMPLOYYE : ");
                    Console.WriteLine(partime1);
                    double finalpay = empfinalhours * empfinalrate;
                    avgpartime += finalpay;
               }
            // Displaying the final result
            }
            Console.WriteLine("The Average Weekly Salary of the all the Salary Employee is : " + avgSal / 3);
            Console.WriteLine("The Average Weekly Salary of the all the Wages Employee is : " + avgwage / 4);
            Console.WriteLine("The Average Weekly Salary of the all the partTime Employee is : " + avgpartime / 2);
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Highest Pay of The Wage Employee is " + higehstpayofwageemp + " By " + higestpayempname);
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Lowest Salary of The Salary Employe is " + lowestsal + " By " + lowestsalname);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Perceantage of Employees in Salary Category: " + Math.Round((s / 9 * 100),2) + " %");
            Console.WriteLine("Perceantage of Employees in Wages Category: " + Math.Round(w / 9 * 100 , 2) + " %");
            Console.WriteLine("Perceantage of Employees in Part time Category: " + Math.Round(p / 9 * 100,2) + " %");
            Console.ReadLine();
        }
    } 
}
