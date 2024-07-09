//Minh họa đa thừa kế sử dụng interface 

// Tạo interface IDate xử lý ngày tháng
interface IDate
{
    // Định nghĩa khuôn mẫu phương thức lấy ngày tháng năm
    public string GetDate();

    // Định nghĩa khuôn mẫu phương thức đặt ngày tháng năm
    public void SetDate(int day, int month, int year);
}

// Tạo interface ITime xử lý giờ phút
interface ITime
{
    // Định nghĩa phương thức lấy giờ phút giây
    public string GetTime();

    // Định nghĩa phương thức đặt giờ phút giây
    public void SetTime(int hour=0, int minute=0, int second=0);
}

// Tạo lớp MyDateTime cài đặt các giao diện IDate, ITime
class MyDateTime: IDate, ITime
{
    // Các trường dữ liệu (fields) riêng của lớp
    private int day, month, year;
    private int second, minute, hour;

    // Cài đặt phương thức GetDate của interface IDate
    public string GetDate()
    {
        return $"{day}/{month}/{year}"; 
    }

    // Cài đặt phương thức SetDate của interface IDate
    public void SetDate(int day, int month, int year)
    {
        if (isValidDate(day, month, year))
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
    }

    // Cài đặt phương thức GetTime của interface ITime
    public string GetTime()
    {
        return $"{hour}:{minute}:{second}";
    }

    // Cài đặt phương thức SetTime của interface ITime
    public void SetTime(int hour=0, int minute=0, int second=0)
    {
        if(isValidTime(hour, minute, second)) 
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }

    // Phương thức trả về chuỗi chứa ngày giờ
    // Dùng từ khóa override để ghi đè phương thức ToString() có sẵn
    public override string ToString()
    {
        if (isValidDate(day, month, year) && isValidTime(hour, minute, second))
            return $"{day:00}/{month:00}/{year:0000}-{hour:00}:{minute:00}:{second:00}";
        else return $"Invalid date or time";
    }

    // Hàm tiện ích kiểm tra ngày tháng có hợp lệ hay không
    static bool isValidDate(int day, int month, int year)
    {
        bool isValid = true;

        if(year < 1 || day < 1 || day > 31 || month < 1 || month > 12) return false;
        
        switch(month) 
        {   // Các tháng 1,3,5,7,8,10,12 có giá trị ngày từ 1-31 
            case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                if(day > 31) isValid = false; break;
            // Các tháng 4,6,9,11 có giá trị ngày từ 1-30 
            case 4: case 6: case 9: case 11:
                if (day > 30) isValid = false; break;
            case 2:
                {
                    // Nếu là năm nhuận thì có 29 ngày
                    if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                    {
                        if (day > 29) isValid = false;
                    }
                    else
                    {
                        if (day > 28) isValid = false;
                    }
                    break;
                }
        }
        return isValid;
    }

    // Hàm tiện ích kiểm tra thời gian hợp lệ
    static bool isValidTime(int hour, int minute, int second)
    {
        return (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59 && second >= 0 && second <= 59);
    }
}