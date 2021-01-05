using System;
using System.Collections;

namespace ConsoleAppDemo
{
    // 借助数组实现一个简单的队列
    public class MMArrayQueue<T>    // 队列中存储泛型类型的数据
    {
        private ArrayList array;

        // 初始化(不带参数)
        public MMArrayQueue()
        {
            array = new ArrayList();
        }

        // 初始化（带参数）
        public MMArrayQueue(int capacity)
        {
            array = new ArrayList(capacity);
        }

        // 是否为空
        public bool IsEmpty()
        {
            return (array.Count <= 0);
        }

        // 当前容量
        public int GetSize()
        {
            return array.Count;
        }

        // 队首元素
        public T GetFront()
        {
            if (this.IsEmpty())
            {
                return default;
            }
            return (T)array[0];
        }

        // 入队
        public void Enqueue(T t)
        {
            array.Add(t);
        }

        // 出队
        public void Dequeue()
        {
            array.RemoveAt(0);
        }
    }
}
