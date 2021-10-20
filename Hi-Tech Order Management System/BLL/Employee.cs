using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.DAL;
namespace Hi_Tech_Order_Management_System.BLL
{
    public class Employee
    {
        int employeeId;
        string firstName;
        string lastName;
        string phoneNumber;
        int jobId;

        public Employee()
        {

        }



        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNUmber { get => phoneNumber; set => phoneNumber = value; }
        public int JobId { get => jobId; set => jobId = value; }


        public List<Employee> GetEmployeeList()
        {
            return EmployeeDB.GetRecordList();
        }

        public void UpdateEmployee(Employee emp)
        {
            EmployeeDB.UpdateRecord(emp);

        }

        public void SaveEmployee(Employee emp)
        {
            EmployeeDB.SaveRecord(emp);
        }

        public Employee SearchById(int stuNum)
        {
            return EmployeeDB.GetRecord(stuNum);
        }

        public void DeleteEmployee(int empId)
        {
            EmployeeDB.DeleteRecord(empId);
        }

        public  Employee SearchEmployee(int eId )
        {
            return EmployeeDB.GetRecord(eId);
        }
    
    }
}
