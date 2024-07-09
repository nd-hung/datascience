# Quản lý nhân viên

---

## Cài đặt lớp NhanVien

### Các trường (fields), thiết lập mức truy cập private

- Mã nhân viên, họ và tên, hệ số lương.
- Trường tĩnh chứa mức lương cơ bản = 1500000.

### Các thuộc tính (properties), thiết lập mức truy cập public

- Các thuộc tính tương ứng truy xuất đến các trường ở trên, trong đó phương thức set có xử lý ràng buộc dữ liệu như sau:
  - Mã nhân viên, họ và tên phải có độ dài > 0
  - Hệ số lương phải nằm trong khoảng [2, 6]

### Các phương thức (methods)

- Thiết lập
- Nhập
- Xuất

## Chương trình chính

- Tạo và nhập danh sách n nhân viên (0 < n < 100) từ bàn phím.
- In danh sách nhân viên vừa nhập, mỗi nhân viên trên một dòng.
- In ra thông tin (các) nhân viên có hệ số lương cao nhất.
- Sắp xếp danh sách nhân viên theo thứ tự giảm dần của tiền lương, biết tiền lương = hệ số lương * lương cơ bản. In ra danh sách sau khi sắp xếp.

## Mã nguồn

[Xem trên GitHub](https://github.com/nd-hung/oop/blob/main/docs/labs/02-classes-and-objects/code/QLNhanVien/Program.cs)
