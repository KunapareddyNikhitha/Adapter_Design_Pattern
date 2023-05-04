using System;
namespace Adapter_Design_Pattern
{
    //Client 
    //The Client is Incompatible with ThirdPartyBillingSystem 
    class Program
    {
        static void Main(string[] args)
        {
            //Storing the Employees Data in a String Array
            string[,] employeesArray = new string[5, 4]
            {
                {"SS221","Nikhitha","SE","10000"},
                {"SS222","RajKiran","SE","200000"},
                {"SS223","Subash","SSE","30000"},
                {"SS224","Dev","SE","40000"},
                {"SS225","Hansika","SSE","50000"}
            };

            //The EmployeeAdapter Makes it possible to work with Two Incompatible Interfaces
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesArray);

            Console.Read();
        }
    }
}