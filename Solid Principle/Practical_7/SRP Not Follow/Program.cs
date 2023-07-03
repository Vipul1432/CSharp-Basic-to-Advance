using Practical_7.Not_Follow;
namespace Practical_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Not Following SRP
            Employee employee = new Employee();
            employee.Employee_Id = 1;
            employee.Employee_Name = "Vipul";
           if(employee.InsertIntoEmployeeTable(employee))
            {
                Console.WriteLine("Employee Inserted In table");
            }
           else
            {
                Console.WriteLine("Employee is not inserted Please try again later");
            }
            employee.GenerateReport(employee);
        }
    }
}