using System;

namespace ConsoleAppDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            ///// 自定义数组
            //MMIntArray intArray = new MMIntArray();
            //intArray.AddtFirst(0);
            //intArray.AddtFirst(1);
            //intArray.RemoveAtFirst();
            //intArray.ReplaceAtIndex(0, 0);


            //Person p = new Person();
            //MMArray<object> array = new MMArray<object>(10);
            //array.AddAtLast(11);
            //array.AddAtLast(p);
            //array.AddtFirst(10);

            //object i = array.GetAtIndex(0);
            //object j = array.GetAtIndex(1);
            //object k = array.GetAtIndex(2);
            //Console.WriteLine(i.ToString());
            //Console.WriteLine(j.ToString());
            //Console.WriteLine(k.ToString());


            /// 栈
            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person();
            MMArrayStack<object> arrayStack = new MMArrayStack<object>();
            arrayStack.push(p1);
            arrayStack.push(p2);
            arrayStack.push(p3);
            Console.WriteLine(arrayStack.peek());
            arrayStack.pop();
            arrayStack.pop();
            Console.WriteLine(arrayStack.peek());

            String str1 = "((";
            StackSulution sulution = new StackSulution();
            Console.WriteLine(sulution.IsValid(str1));


        }
    }

    class Person
    {

    }
}