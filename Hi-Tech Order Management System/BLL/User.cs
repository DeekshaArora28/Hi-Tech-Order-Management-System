using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.DAL;


namespace Hi_Tech_Order_Management_System.BLL
{
    public class User
    {
        string userName;
        string password;
        int employeeId;

        public User()
        {
            
        }

      

        public string UserName{ get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }

        public void SaveUser(User emp)
        {
            UserDB.SaveRecord(emp);
        }

        public List<User> GetEmployeeList()
        {
            return UserDB.GetRecordList();
        }

       public User GetUser(int user)
        {
            return UserDB.GetRecord(user);
        }
        
        public void Update(User usr)
        {
             UserDB.UpdateRecord(usr);
        }

        public void Delete(int userName)
        {
            UserDB.DeleteRecord(userName);
        }

    }
}
