using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleAppDemo
{
    // 借助数组实现一个简单的栈
    public class MMArrayStack<T>
    {
        private ArrayList array;

        // 构造函数
        public MMArrayStack()
        {
            array = new ArrayList();
        }
        public MMArrayStack(int capacity)
        {
            array = new ArrayList(capacity);
        }

        // 压栈
        public void push(T t)
        {
            array.Add(t);
        }

        // 出栈
        public void pop()
        {
            if (array.Count > 0)
            {
                array.RemoveAt(array.Count - 1);
            }
        }

        // 获取栈顶元素
        public T peek()
        {
            if (array.Count > 0)
            {
                return (T)array[array.Count - 1];
            }
            else
            {
                return default(T);
            }
        }
    }


    // leetcode 20.有效的括号 
    class StackSulution
    {
        public bool IsValid(string s)
        {
            Stack stack = new Stack();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '[' || c == '(' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count <= 0)
                    {
                        return false;
                    }

                    Char top = (Char)stack.Peek();

                    if (c == ']' && top == '[')
                    {
                        stack.Pop();
                    }
                    else if (c == ')' && top == '(')
                    {
                        stack.Pop();
                    }
                    else if (c == '}' && top == '{')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count % 2 == 0;
        }
    }
}
