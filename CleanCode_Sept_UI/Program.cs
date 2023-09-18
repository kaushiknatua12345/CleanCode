using System;
using System.Collections.Generic;
using CleanCode_Sep18_Repository;

public class Program
{
    public static void Main(string[] args)
    {
        string loopCondition=string.Empty;
        do
        {
            Console.WriteLine("Press 1 for Login\nPress 2 to search records via department:");
            int caseCondition = int.Parse(Console.ReadLine());
            switch (caseCondition)
            {
                case 1:
                    {
                        Console.WriteLine("\nEnter Employee Id: ");
                        int searchedId= int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Password: ");
                        string searchedPassword = Console.ReadLine();
                        EmployeeRepository class1 = new EmployeeRepository();
                        bool result = class1.Login(searchedId, searchedPassword);
                        if (result==true)
                        {
                            Console.WriteLine("\nLogin Successful");
                        }
                        else
                        {
                            Console.WriteLine("\nLogin Failed");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nEnter Department Name: ");
                        string searchedDepartment = Console.ReadLine();
                        EmployeeRepository class1 = new EmployeeRepository();
                        List<EmployeeModel> list = class1.SearchByDepartment(searchedDepartment);
                        if (list.Count() > 0)
                        {
                            Console.WriteLine("Name\tId\tDepartment");
                            foreach (EmployeeModel EmployeeModel in list)
                            {
                                Console.WriteLine(EmployeeModel.Name + "\t" + EmployeeModel.Id + "\t" + EmployeeModel.Department);

                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNo records found");
                        }
                        break;
                    }
            }
            Console.WriteLine("Press Y to continue..Any other key to terminate: ");
            loopCondition = Console.ReadLine();
        }
        while (loopCondition.ToUpper().Equals("Y"));

        Console.ReadKey();
        
    }
}