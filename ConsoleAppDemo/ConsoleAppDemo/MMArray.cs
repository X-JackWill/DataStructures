using System;
namespace ConsoleAppDemo
{
    // 自定义Int类型的数组
    public class MMArray<T>
    {
        private T[] data;           // 存储素的数组
        private static int size;    // 数组大小

        public MMArray()
        {
            data = new T[10];
            size = 0;
        }

        // 初始化
        public MMArray(int capacity)
        {
            data = new T[capacity];
            size = 0;
        }

        // 获取数组容量
        public int GetCapacity()
        {
            return data.Length;
        }

        // 获取数组大小
        public int GetSize()
        {
            return size;
        }

        // 是否为空
        public bool IsEmpty()
        {
            return size == 0;
        }

        // 添加
        public void AddAtLast(T ele)
        {
            AddAtIndex(ele, size);
        }
        public void AddtFirst(T ele)
        {
            AddAtIndex(ele, 0);
        }
        public void AddAtIndex(T ele, int index)
        {
            if (size == data.Length)  // 如果当前元素个数 = 数组总长度，则数组容量已满
            {
                throw new Exception("array is full");
            }
            if (index < 0 || index > size)
            {
                throw new Exception("Invalid");
            }
            for (int i = size - 1; i >= index; i--) // 将index位置以后的元素都向后移一个位置
            {
                data[i + 1] = data[i];
            }
            data[index] = ele;
            size++;
        }

        // 删除
        public void RemoveAtFirst()
        {
            RemoveAtIndex(0);
        }
        public void RemoveAtLast()
        {
            RemoveAtIndex(size - 1);
        }
        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }
            for (int i = index; i < size - 1; i++) // 将index位置以后的元素都向前移一个位置
            {
                data[i] = data[i + 1];
            }
            data[size] = default(T);
            size--;
        }
        public void Remove(T ele)
        {
            int index = GetIndex(ele);
            if (index > 0)
            {
                RemoveAtIndex(index);
            }
        }

        // 获取元素下标
        public int GetIndex(T ele)
        {
            for (int i = 0; i < size; i++)
            {
                if (ele.Equals(data[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        // 替换
        public void ReplaceAtIndex(T ele, int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }
            data[index] = ele;
        }

        // 获取元素
        public T GetAtIndex(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new Exception("Invalid");
            }
            return data[index];
        }

        // 是否包含
        public bool IsContains(T ele)
        {
            for (int i = 0; i < size; i++)
            {
                if (data[i].Equals(ele))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
