
    interface I1
    {
        static I1()
        {
            Console.WriteLine("Hi");
        }
        void Print();
        public void Mymethod()
        {
            Console.WriteLine("Method");
        }

    }
    class NewClass : I1
    {
        static void Main(string[] args)
        {
            I1 nw = new NewClass();
            nw.Mymethod();
    }
        void I1.Print()
        {
            Console.WriteLine("Hi newclass");
        }
    
    }