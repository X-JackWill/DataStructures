using System;

namespace ConsoleAppDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /// 找出一些数中的最大数

            // 定义一个数组，存储一些数
            int[] nums = { 2, 4, 6, 9, 20, 21 , 3, 5};
            // 默认数组的第一个元素为最大值
            int Max = nums[0];
            // 通过for循环，当前数与最大的数进行对比
            for (int i = 0; i < nums.Length; i++) {
                int num = nums[i];
                // 如果当前的数大于最大的数，将当前的数作为做大数
                if (Max < num) {
                    Max = num;
                }
                // 当所有的数都比较完之后，输出最大数
                if (i >= nums.Length - 1) {
                    Console.WriteLine(Max);
                }
            }
            








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
            //Person p1 = new Person();
            //Person p2 = new Person();
            //Person p3 = new Person();
            //MMArrayStack<object> arrayStack = new MMArrayStack<object>();
            //arrayStack.push(p1);
            //arrayStack.push(p2);
            //arrayStack.push(p3);
            //Console.WriteLine(arrayStack.peek());
            //arrayStack.pop();
            //arrayStack.pop();
            //Console.WriteLine(arrayStack.peek());

            //String str1 = "[";
            //StackSulution sulution = new StackSulution();
            //Console.WriteLine(sulution.IsValid(str1));


            //// 队列
            //MMArrayQueue<object> arrayQueue = new MMArrayQueue<object>();
            //arrayQueue.Enqueue(1);
            //arrayQueue.Enqueue(2);
            //arrayQueue.Enqueue(3);
            //Console.WriteLine(arrayQueue.GetFront());
            //arrayQueue.Dequeue();
            //arrayQueue.Dequeue();
            //arrayQueue.Dequeue();
            //Console.WriteLine(arrayQueue.GetFront());
        }
    }

    class Person
    {

    }
}