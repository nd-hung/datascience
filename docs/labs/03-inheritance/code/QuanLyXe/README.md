# Quản lý xe

---

## Mô tả bài toán

- Phương tiện xe cơ giới có nhiều loại, mọi loại xe đều có các thuộc tính: biển số, năm sản xuất, các phương thức nhập, xuất thông tin xe.
- Xe con ngoài các đặc điểm chung có thêm thuộc tính số chỗ ngồi.
- Xe tải ngoài các đặc điểm chung có thuộc tính tải trọng (tính bằng kg).

Theo mô tả trên, có thể biểu diễn mối quan hệ giữa các lớp Xe, XeCon, XeTai bằng lược đồ UML dưới đây.

![UML diagram](img/Xe.svg)

## Yêu cầu

### Cài đặt lớp cơ sở Xe

- Các thuộc tính: biển số, năm sản xuất.
- Các phương thức: nhập, xuất thông tin xe.

### Cài đặt lớp dẫn xuất XeCon

- Các thuộc tính: số chỗ ngồi.
- Các phương thức: nhập, xuất thông tin xe con.

### Cài đặt lớp dẫn xuất XeTai

- Các thuộc tính: tải trọng.
- Các phương thức: nhập, xuất thông tin xe tả.

### Chương trình chính

- Nhập danh sách xe duy nhất quản lý thông tin của phương tiện xe con và xe tải.
- In ra danh sách xe.
- Đếm số lượng xe của mỗi loại.
- Tìm xe có năm sản xuất cũ nhất của mỗi loại.

## Mã nguồn

[Xem trên GitHub](https://github.com/nd-hung/oop/blob/main/docs/labs/03-inheritance/code/QuanLyXe/)