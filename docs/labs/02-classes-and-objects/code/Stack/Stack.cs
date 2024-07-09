/*
Cài đặt lớp Stack mô tả cấu trúc ngăn xếp xử lý các phần tử là số nguyên.
*/
using System;

class Stack
{
    private static readonly int Max=1000;  // Số phần tử tối đa của ngăn xếp
    private int _top;               // chỉ số của phần tử trên cùng
    private int[] _stack = new int[Max];            // mảng chứa các phần tử

    // Hàm thiết lập
    public Stack()
    {
        _top = -1;      // Khởi tạo ngăn xếp rỗng
    }

    // phương thức thêm 1 phần tử vào ngăn xếp
    public void Push(int data)
    {
        if(_top >= Max)
            Console.WriteLine("Ngan xep day! Khong chua them duoc!");
        else
        {
            _top ++;
            _stack[_top] = data;
        }
    }

    // Lấy phần tử trên cùng ra khỏi ngăn xếp & trả về cho lời gọi hàm
    public int Pop()
    {
        if(_top >= 0)    
            {
                int data = _stack[_top];
                _top--;
                return data;
            }
        else return -1;
    }

    // In ra toàn bộ các phần tử trong stack
    public void Print()
    {
        if(_top < 0)    
            Console.WriteLine("Ngan xep rong!");
        else
            for(int i=_top; i > 0; i--)
                Console.Write("{0}*", _stack[i]);
            Console.Write("{0}", _stack[0]);
    }

    // Hàm in ra các phần tử (là số dư của phép chia cho 16)
    public void PrintHex()
    {
        string csHex = "0123456789ABCDEF";
        for(int i=_top; i >= 0; i--)
            Console.Write(csHex[_stack[i]]);
    }
}