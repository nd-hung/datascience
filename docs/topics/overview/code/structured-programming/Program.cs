/*
Minh họa lập trình cấu trúc với C#
Input: Dãy số nguyên
Output: Dãy số được sắp xếp tăng dần
*/

/* Mã nguồn sau đây được viết dưới dạng 'Top-level statements'.
Đây là tính năng có từ C# 9.0/.NET 5.0, cho phép viết các dòng code trực tiếp
mà không cần đưa vào các lớp hay phương thức.
*/


/*----------- Chương trình chính ---------- */
// Khai báo mảng số nguyên
int n = 6;                  // n: số phần tử
int[] numbers = new int[n]; // numbers: mảng chứa các phần tử

// Gọi hàm tạo mảng
TaoMang(numbers, n);

// Gọi hàm in ra danh sách ban đầu
Console.WriteLine("\nMang ban dau:");
InMang(numbers, n);

// Gọi hàm sắp xếp tăng dần
SapXepTD(numbers, n);

// Gọi hàm in ra danh sách đã sắp xếp
Console.WriteLine("\nMang sau khi sap xep:");
InMang(numbers, n);
/*----------- Kết thúc chương trình chính ---------- */


/*-------------- Cài đặt các hàm ------------------ */
// Hàm tạo mảng có n số nguyên ngẫu nhiên 
void TaoMang(int[] array, int n)
{
    // Khởi tạo bộ tạo số ngẫu nhiên
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
        array[i] = rnd.Next(100);
}

// Hàm sắp xếp mảng tăng dần
void SapXepTD(int[] a, int n)
{
    for (int i = 0; i < n - 1; i++)
        for (int j = i + 1; j < n; j++)
            if (a[i] > a[j])
            {
                int t = a[i];
                a[i] = a[j];
                a[j] = t;
            }
}

// Hàm in mảng
void InMang(int[] a, int n)
{
    for (int i = 0; i < n; i++)
        Console.Write("{0} ", a[i]);
}