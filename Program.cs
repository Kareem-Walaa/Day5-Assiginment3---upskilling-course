using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        enum enDepartment
        {
            HR = 1,
            IT = 2 ,
            Sales = 3 ,
            Finance = 4
        }
        struct stEmployee
        {
          public  int ID;
          public  String Name;
          public  Double Salary;
          public  enDepartment Department;

        }
        static void Main(string[] args)
        {


            stEmployee[] employees = new stEmployee[10];
            // employees data genrated by chatgpt
            employees[0] = new stEmployee { ID = 01, Name = "Ahmed Ali", Salary = 5000.0, Department = enDepartment.HR };
            employees[1] = new stEmployee { ID = 02, Name = "Mohamed Saeed", Salary = 6000.0, Department = enDepartment.IT };
            employees[2] = new stEmployee { ID = 03, Name = "Layla Hassan", Salary = 4500.0, Department = enDepartment.Sales };
            employees[3] = new stEmployee { ID = 04, Name = "Maryam Abdullah", Salary = 7000.0, Department = enDepartment.Finance };
            employees[4] = new stEmployee { ID = 05, Name = "Khaled Mahmoud", Salary = 5500.0, Department = enDepartment.HR };
            employees[5] = new stEmployee { ID = 06, Name = "Suad Ahmed", Salary = 4800.0, Department = enDepartment.Sales };
            employees[6] = new stEmployee { ID = 07, Name = "Ali Youssef", Salary = 6200.0, Department = enDepartment.IT };
            employees[7] = new stEmployee { ID = 08, Name = "Fatima Omar", Salary = 4700.0, Department = enDepartment.HR };
            employees[8] = new stEmployee { ID = 09, Name = "Yasser Abdelrahman", Salary = 5300.0, Department = enDepartment.Finance };
            employees[9] = new stEmployee { ID = 10, Name = "Noura Fathi", Salary = 4900.0, Department = enDepartment.Sales };

            // display employee data
            foreach (var employee in employees)
            {
                Console.WriteLine("----------------");
                Console.WriteLine($" ID: {employee.ID}\n Name: {employee.Name}\n Salary: {employee.Salary}\n Department: {employee.Department}\n");
            }
            Console.WriteLine("----------------");

            // total saleries
            double total_salaries = 0;
            int i = 0;
            foreach (var item in employees)
            {
                total_salaries = employees[i].Salary + total_salaries;
                i++;
            }
            Console.WriteLine($" Our Company pays total salaries : {total_salaries}");


            //Find The highest employee

            double max = 0;
            string name = "";
            string department = "";
            for (int j = 0; j < employees.Length; j++)
            {
                if (employees[j].Salary > max)
                {
                    max = employees[j].Salary;
                    name = employees[j].Name;
                    department =employees[j].Department.ToString();
                }

            }

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($" The highest paied employee is {name} - salary : {max} - department : {department} ");
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
