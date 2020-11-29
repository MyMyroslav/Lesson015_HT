using System;

namespace Lesson015_HT_Task3
{
    class MainClass
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Changed";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Changed";
        }
        public static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.change = "no changed";
            MyStruct myStruct = new MyStruct();
            myStruct.change = "no change";
            Console.WriteLine($"{myClass.change}, {myStruct.change}");
        }
    }
}
