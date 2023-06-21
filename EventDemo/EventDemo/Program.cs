namespace EventDemo
{
    internal class EventClass
    {
        //! Creating a delegate
        public delegate void MyDelegate(int a);

        //! Creating an Event
        public event MyDelegate? MyEvent;
       
        //! Method which raise event
        public void RaiseMyEvent()
        {
            Console.WriteLine("Loading ....");
            Thread.Sleep(2000);
            //! Raise a Event
            //if (MyEvent != null ) { MyEvent(); }
            MyEvent?.Invoke(15);
            
        }
    }
    internal class Class1
    {
        public static void Main(string[] args)
        {
            Class1 class1 = new Class1();   
            EventClass ec = new EventClass();
            //! Subscribe Event-1
            ec.MyEvent += (int a) => { Console.WriteLine($"Hello world {a}"); };
            //! Subscribe Event-2
            //ec.MyEvent += Class2.OnMyEventRaised2;
            //! Calling EventRaise Method
            ec.RaiseMyEvent();
        }
        public void OnMyEventRaised1(int a)
        {
            Console.WriteLine("First Event Raised");
        }
    }
    internal class Class2
    {
        public static void OnMyEventRaised2()
        {
            Console.WriteLine("Second Event Raised");
        }
    }

}