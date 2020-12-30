using System;
namespace ConsoleAppDemo
{
    public class MMIntArray
    {
        private int[] data; // 整形数组
        private int size;   // 数组当前的元素个数/容量

        // 初始化方法
        public MMIntArray(int capacity)    // 传入参数capacity，设置数组的总容量
        {
            data = new int[capacity];
            size = 0;   // 初始是个空数组，当前无元素，size为0。
        }

        // 初始化方法
        public MMIntArray()
        {
            data = new int[100];
            size = 0;  
        }

        // 获取数组容量
        public int GetCapacity()
        {
            return data.Length;
        }

        // 获取数组元素个数
        public int GetSize()
        {
            return size;
        }

        // 数组是否为空
        public bool IsEmpty()
        {
            return size == 0;
        }

        // 末尾添加
        public void AddAtLast(int ele)
        {
            AddAtIndex(ele, size);
        }
        // 首位添加
        public void AddtFirst(int ele)
        {
            AddAtIndex(ele, 0);
        }
        // 任意位置添加
        public void AddAtIndex(int ele, int index)
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

        // 删除首位置
        public void RemoveAtFirst()
        {
            RemoveAtIndex(0);
        }
        // 删除首位置
        public void RemoveAtLast()
        {
            RemoveAtIndex(size - 1);
        }
        // 删除任意位置的元素
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
            data[size] = 0;
            size--;
        }
        // 删除某元素
        public void Remove(int ele)
        {
            int index = GetIndex(ele);
            if (index > 0)
            {
                RemoveAtIndex(index);
            }
        }

        // 获取某元素的下标
        public int GetIndex(int ele)
        {
            for (int i = 0; i < size; i++)
            {
                if (ele == data[i])
                {
                    return i;
                }
            }
            return -1;
        }

        // 替换index位置的元素
        public void ReplaceAtIndex(int ele, int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }
            data[index] = ele;
        }

        // 查下标为index的元素
        public int GetAtIndex(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new Exception("Invalid");
            }
            return data[index];
        }

        // 是否包含
        public bool IsContains(int ele)
        {
            for (int i = 0; i < size; i++)
            {
                if (ele == data[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
