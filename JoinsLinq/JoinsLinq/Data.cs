namespace JoinsLinq
{
    internal static class Data
    {
        public readonly static List<int> NumbersList = new();
        public readonly static List<Student> StudentList;
        public readonly static List<Employee> EmpList;
        public readonly static List<Leave> LeaveList;
        public readonly static List<Department> DeptList;
        public readonly static List<object> MixedData;
        static Data()
        {
            for (int i = 1; i < 10000; i++) NumbersList.Add(i);



            StudentList = new List<Student>()
            {
            new Student(){ID = 1, Name = "Vipul", Gender = "Male"},
            new Student(){ID = 2, Name = "Bhavin", Gender = "Male"},
            new Student(){ID = 3, Name = "Jil", Gender = "Male"},
            new Student(){ID = 4, Name = "Abhi", Gender = "Male"},
            new Student(){ID = 11, Name = "Tessa", Gender = "Female"},
            new Student(){ID = 12, Name = "Salena Gomez", Gender = "Female"},
            new Student(){ID = 13, Name = "Enrich", Gender = "Female"},
            new Student(){ID = 14, Name = "Ema Watson", Gender = "Female"}
            };



            MixedData = new List<object>() { 1, 2, "Hello", "World", new Student() { ID = 1, Name = "Vipul", Gender = "Male" } };



            DeptList = new List<Department>()
            {
            new Department(){ ID = 1, Name = "ASP.NET"},
            new Department(){ ID = 2, Name = "PHP"},
            new Department(){ ID = 3, Name = "JAVA"},
            new Department(){ ID = 4, Name = "OPENSOURCE"}
            };



            EmpList = new List<Employee>()
            {
            new Employee(){ID = 1, Name = "Vipul", Gender = "Male" , DOB=DateOnly.Parse("09-02-1999"), DeptId = 1},
            new Employee(){ID = 2, Name = "Bhavin", Gender = "Male",DOB=DateOnly.Parse("09-02-2002"), DeptId = 3},
            new Employee(){ID = 3, Name = "Jil", Gender = "Male",DOB=DateOnly.Parse("09-09-2000"), DeptId = 4},
            new Employee(){ID = 4, Name = "Abhi", Gender = "Male",DOB=DateOnly.Parse("02-02-2001"), DeptId = 2},
            new Employee(){ID = 5, Name = "Tessa", Gender = "Female",DOB=DateOnly.Parse("06-01-2002"), DeptId = 1},
            new Employee(){ID = 6, Name = "Salena Gomez", Gender = "Female",DOB=DateOnly.Parse("09-08-1965"), DeptId = 1},
            new Employee(){ID = 7, Name = "Enrich", Gender = "Female",DOB=DateOnly.Parse("01-03-1988"), DeptId = 3},
            new Employee(){ID = 8, Name = "Ema Watson", Gender = "Female",DOB=DateOnly.Parse("05-04-2006"), DeptId = 2},
            new Employee(){ID = 9, Name = "Charlie puth", Gender = "Male",DOB=DateOnly.Parse("03-08-1987"), DeptId = 6},
            new Employee(){ID = 10, Name = "Post malone", Gender = "Male",DOB=DateOnly.Parse("05-04-2006"), DeptId = 8}
            };



            LeaveList = new()
            {
            new Leave(){ID = 101, EmpId = 1, Date = DateOnly.Parse("23-12-2023"), Reason = "Family Function",Title = "Functional Leave" },
            new Leave(){ID = 102, EmpId = 2, Date = DateOnly.Parse("12-04-2023"), Reason = "Cold, Feaver",Title = "illness & weekness" },
            new Leave(){ID = 103, EmpId = 3, Date = DateOnly.Parse("05-02-2023"), Reason = "Leg injury",Title = "Injury" },
            new Leave(){ID = 104, EmpId = 4, Date = DateOnly.Parse("26-09-2022"), Reason = "Paid Leave",Title = "PAID ELAVE" },
            };
        }
    }
}
