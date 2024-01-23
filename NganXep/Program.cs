using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NganXep
{
    class Stack
    {
        private int[] data;
        private int top;
        //định nghĩa các pt khởi tạo
        public Stack()
        {
            data = new int[100];
            top = -1;
        }
        public Stack(int size)
        {
            data = new int[size];
            top = -1;
        }
        //định nghĩa pt kiểm tra rỗng
        public bool isEmpty()
        {
            bool kq = false;
            if (top == -1)
                kq = true;
            return kq;
        }
        public bool isFull()
        {
            bool kq = false;
            if (top == data.Length - 1)
                kq = true;
            return kq;
        }
        public void Push(int x)
        {
            if(isFull())
            {
                Console.WriteLine("Stack đã đầy.Thêm thất bại");
            }
            else
            {               
                data[++top] = x;
            }    
        }
        public int Pop()
        {
            int kq=0 ;
            if(isEmpty())
            {
                Console.WriteLine("Stack đã đầy.Thêm thất bại");
            }
            else
            {
                kq = data[top--];
            }
            return kq;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.Write("Nhập hệ số 10:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhập cơ số cân đôi:");
            int x = int.Parse(Console.ReadLine());
            Stack s = new Stack();
            while(n>0)
            {
                s.Push(n % x);
                n = n / x;
            }
            Console.Write("Biểu diễn hệ:");
            while(!s.isEmpty())
            {
                Console.Write(s.Pop());
            }
            Console.ReadLine();
        }
    }
}
