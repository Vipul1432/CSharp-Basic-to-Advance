namespace InterviewQueryLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Second Highest Salary

            // 1st way to find second highest salary
            var firstwayqs = (from emp in Data.EmpList
                             orderby emp.Salary descending
                             select emp).Skip(1).Take(1);
            foreach (var item in firstwayqs)
            {
                Console.WriteLine($"Name : {item.Name} Dob : {item.DOB} Salary : {item.Salary}");
            }

            Console.WriteLine("=============================");

           var firstwayle = Data.EmpList.OrderByDescending(emp => emp.Salary).Take(2).OrderBy(emp => emp.Salary).Take(1);

            foreach (var item in firstwayle)
            {
                Console.WriteLine($"Name : {item.Name} Dob : {item.DOB} Salary : {item.Salary}");
            }

            Console.WriteLine("=============================");

            // Second Way to find Second Highest Salary
            var secondwayle = Data.EmpList.OrderByDescending(emp => emp.Salary).Skip(1).Take(1);
            foreach (var item in secondwayle)
            {
                Console.WriteLine($"Name : {item.Name} Dob : {item.DOB} Salary : {item.Salary}");
            }

            Console.WriteLine("=============================");

            // Third Way to find Second Highest Salary
            var thirdwayle = Data.EmpList.OrderByDescending(s => s.Salary).Select(emp => emp.Salary).Distinct().Skip(1).First();
            var sc = Data.EmpList.Where(e => e.Salary == thirdwayle).ToList();

            foreach (var item in sc)
            {
                Console.WriteLine($"Name : {item.Name} Dob : {item.DOB} Salary : {item.Salary}");
            }

            Console.WriteLine("=============================");

            // Fourth Way(Best) to find Second Highest Salary
            var fourthwayle = Data.EmpList.OrderByDescending(emp => emp.Salary).GroupBy(emp => emp.Salary).Skip(1).First();

            foreach (var item in fourthwayle)
            {
                Console.WriteLine($"Name : {item.Name} Dob : {item.DOB} Salary : {item.Salary}");
            }

            #endregion

            Console.WriteLine("=============> Select Date Between <=================");

            #region Select Date Between

            var SelectBtnDate = Data.EmpList.Where(emp => emp.DOB > DateOnly.ParseExact("09-02-1999", "dd-MM-yyyy") && emp.DOB < DateOnly.ParseExact("15-04-2006", "dd-MM-yyyy")).OrderBy(emp => emp.DOB);

            foreach (var item in SelectBtnDate)
            {
                Console.WriteLine($"Id : {item.ID} Name : {item.Name} Date of Birth : {item.DOB}");
            }

            #endregion Select Date Between 

            #region Upper Letter Count

            var upperCount = "Hello World Data Is HERE".ToArray().AsEnumerable().Where(e => Char.IsUpper(e)).Count();
            Console.WriteLine($"Total upper letters are {upperCount}");

            #endregion

            #region Total No appers count

            var NoOfAppears = new List<int> { 12, 12, 32, 43, 54, 0, 6, 6, 45, 3, 4, 2, 33, 45, 46, 4564, 5, 345, 3, 4353, 45, 3 }.GroupBy(d => d).Select(e => e.Key + " => " + e.Count());
            foreach (var item in NoOfAppears)
            {
                Console.WriteLine(item);
            }
            #endregion            

            #region Max Appears char

            var maxCount = "HeLloWorldDataIsHEREafdkasjdfkaaaaaaaaaaaaaaaaaaaaaaaaaaaa".ToArray().AsEnumerable().GroupBy(e => Char.ToLower(e)).Select(e => new { e, maxis = e.Count() }).OrderByDescending(e => e.maxis).Take(1);
            foreach (var item in maxCount)
            {
                Console.WriteLine($"Maximum times appear char is '{item.e.Key}' It appears {item.maxis} times");
            }

            #endregion

            #region Inner Join 

            var InnerJoinqs = (from emp in Data.EmpList
                               join dept in Data.DeptList
                               on emp.DeptId equals dept.ID
                               select new
                               {
                                   EmployeeName = emp.Name,
                                   Dob = emp.DOB,
                                   Salary = emp.Salary,
                                   DepartmentName = dept.Name
                               });

            var InnnerJoinle = Data.EmpList.Join(Data.DeptList,
                                                 emp => emp.DeptId,
                                                 dept => dept.ID,
                                                 (emp, dept) => new
                                                 {
                                                     EmployeeName = emp.Name,
                                                     Dob = emp.DOB,
                                                     Salary = emp.Salary,
                                                     DepartmentName = dept.Name
                                                 });
            foreach (var item in InnnerJoinle)
            {
                Console.WriteLine($"Employee Name : {item.EmployeeName} Dob : {item.Dob} Salary : {item.Salary}  Department Name : {item.DepartmentName}");
            }

            #endregion

            #region Left Join

            var LeftJoinqs = (from emp in Data.EmpList
                              join dept in Data.DeptList
                              on emp.DeptId equals dept.ID
                              into empGroup
                              from empgrp in empGroup.DefaultIfEmpty()
                              select new
                              {
                                  Name = emp.Name,
                                  Salary = emp.Salary,
                                  DepartmentName = empgrp != null ? empgrp.Name : "NA"
                              }).ToList();

            var LeftJoinle = Data.EmpList.GroupJoin(Data.DeptList,
                                       emp => emp.DeptId,
                                       dept => dept.ID,
                                       (emp, dept) => new
                                       {
                                           emp,
                                           dept
                                       }).SelectMany(x => x.dept.DefaultIfEmpty(), (emp, dept) => new { emp, dept = dept != null ? dept.Name : "NA" }).ToList();
            foreach (var item in LeftJoinqs)
            {
                Console.WriteLine($"{item.Name} Salary : {item.Salary} Department Name : {item.DepartmentName}");
            }

            #endregion
        }
    }
}