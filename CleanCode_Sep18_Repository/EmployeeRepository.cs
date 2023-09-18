using System.Collections.Generic;
using System.Linq;

namespace CleanCode_Sep18_Repository
{
    public class EmployeeRepository
    {
        static List<EmployeeModel> list = new List<EmployeeModel>()
        {
            new EmployeeModel{Name="Sam",Id=1001,Password="sam@123",Department="HR"},
            new EmployeeModel{Name="Joe",Id=1002,Password="joe@123",Department="IT"},
            new EmployeeModel{Name="Jimmy",Id=1003,Password="jimmy@123",Department="HR"},
            new EmployeeModel{Name="Tom",Id=1004,Password="tom@123",Department="Finance"},
            new EmployeeModel{Name="Henry",Id=1005,Password="henry@123",Department="HR"},

        };
        public bool Login(int searchedId,string searchedPassword)
        {
            var find=list.Where(k=>k.Id==searchedId && k.Password==searchedPassword).FirstOrDefault(); 
            if (find != null)  
                return true;  
            else   
                return false;
                   
        }

        public List<EmployeeModel>? SearchByDepartment(string searchedDepartment)
        {
            List<EmployeeModel> find=list.Where(k=>k.Department.ToLower()==searchedDepartment.ToLower()).Select(k=>k).OrderByDescending(k=>k.Department).ToList();
            return find;                 
        }
    }
}