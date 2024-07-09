using System;

// Lớp cơ sở Stack
class Stack
{
    protected static readonly int Max = 1000;   // số phần tử tối đa
    protected int top;  // vị trí của phần tử trên cùng
    protected int[] data = new int[Max];    // mảng chứa các phần tử

    // constructor
    public Stack()
    {
        top = -1;   // khởi tạo ngăn xếp rỗng
    }

    
    public bool Push(int value)
    {
        // check if stack overflow
        if(top >= Max)
        {
            Console.WriteLine("Stack overflow.");
            return false;
        }
        else
        {
            data[++top] = value;
            return true;
        }
    }

    // Pop
    public int Pop()
    {
        if(top < 0)
        {
            Console.WriteLine("Stack empty.");
            return -1;
        }
        else
        {
            int value = data[top--];
            return value;
        }
    }

    //virtual method
    public virtual void Print(){}
}

// Derived classes
class PrimeStack: Stack
{
    
    public PrimeStack():base(){}

    /*
    In ra dãy các thừa số nguyên tố của số tự nhiên (> 1) lưu trong ngăn xếp.
    */
    public override void Print()
    {
        int i;
        // In theo thứ tự ngược lại
        for(i=top; i > 0; i--)
            Console.Write("{0}*", data[i]);
        Console.WriteLine("{0}", data[i]);
    }
}

class HexaStack:Stack
{
    public HexaStack():base(){}

    /*
    In biểu diễn của các số tự nhiên trong ngăn xếp trong hệ 16.
    Ngăn xếp lưu các số nguyên là số dư của quá trình đổi sang hệ 16.
    Ví dụ, với data[]={2, 15, 9, 12} in ra {'2', 'F', '9', 'C'}
    */
    public override void Print()
    {
        string HexaDigits = "0123456789ABCDEF";
        for(int i=top; i >= 0; i--)
            Console.Write(HexaDigits[data[i]]);       
    }
}