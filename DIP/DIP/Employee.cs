
namespace DIP
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
    //! Low Level class
    public class EmployeeDataAccess
    {
        //! Details 
        public Employee GetEmployeeDtails(int ID)
        {
            Employee emp = new Employee()
            {
                ID = 1,
                Name = "Vipul",
                Department = "Computer Engineering",
                Salary = 5000
            };
            return emp;
        }
    }
    public class DataAccessFactory
    {
        public static EmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
    // High Level Module
    public class EmployeeBusinessLogic
    {
        EmployeeDataAccess _employeeDataAccess;
        public EmployeeBusinessLogic()
        {
            _employeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
            Console.WriteLine(_employeeDataAccess.GetEmployeeDtails(1000).Name);
        }
        public Employee GetEmployeeDtails(int id)
        {
            return _employeeDataAccess.GetEmployeeDtails(id);
        }
    }
}
