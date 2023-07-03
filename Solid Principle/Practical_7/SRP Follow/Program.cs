namespace Practical_7.SRP_Follow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Follow SRP
            Employee employee = new Employee();
            employee.Employee_Id = 1;
            employee.Employee_Name = "Vipul";
            employee.InsertIntoEmployeeTable(employee);
            GenerateReports generateReports = new GenerateReports();
            generateReports.Employee_Id = employee.Employee_Id;
            generateReports.Employee_Name = employee.Employee_Name;
            generateReports.GenerateReport(employee);
        }
    }
}
