namespace Practical_7.SRP_Follow
{
    internal class GenerateReports
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
        public void GenerateReport(Employee em)
        {
            // Report generation with employee data using crystal report.
            Console.WriteLine($"{Employee_Name}'s Report Generated");
        }
    }
}
