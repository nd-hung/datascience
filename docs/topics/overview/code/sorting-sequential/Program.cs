namespace sorting_sequential;
class Program
{
    static void Main(string[] args)
    {
        // Khởi tạo dãy số
        int n=6;
        int[] numbers = new int[] {3,8,2,1,6,5};

        // In dãy ban đầu
        Console.WriteLine("Day ban dau:");
        int i = 0;
        LOOP1:
            Console.Write("{0} ", numbers[i]);
            i += 1;
            if(i < n) goto LOOP1;

        // Sắp xếp dãy tăng dần
        i=0;
        OUTER_LOOP:
            int j=i+1;
            INNER_LOOP:
                if(numbers[i] > numbers[j])
                    {
                        int t = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = t;
                    }
                j += 1;
                if(j < n) goto INNER_LOOP;
            i += 1;
            if(i < n-1) goto OUTER_LOOP;

        // In ra dãy đã sắp xếp
        Console.WriteLine("\nDay tang dan:");
        i = 0;
        LOOP2:
            Console.Write("{0} ", numbers[i]);
            i += 1;
            if(i < n) goto LOOP2;
    }
}
