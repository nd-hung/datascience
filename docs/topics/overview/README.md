# Tổng quan về lập trình hướng đối tượng

Overview

---

Cho đến nay có hai phương pháp lập trình phổ biến nhất là **lập trình cấu trúc** và **lập trình hướng đối tượng**.

## Lập trình cấu trúc (Structural Programming)

- Còn gọi là lập trình hướng thủ tục (procedural programming) vận dụng cách tiếp cận từ trên xuống (top-down development), từ tổng quát đến chi tiết.
- Chương trình được phân rã thành các chức năng riêng biệt, các chức năng này nếu cần lại có thể được chia nhỏ thành các chức năng nhỏ hơn. Mỗi chức năng con này được cài đặt thành một chương trình con tương ứng. Mỗi chương trình con có thể được gọi nhiều lần với các dữ liệu vào khác nhau.

Ví dụ: Cho một mảng số nguyên, sắp xếp mảng tăng dần, in mảng đã sắp xếp.

Theo yêu cầu bài toán, chương trình được phân rã thành các chức năng: tạo mảng, sắp xếp mảng, in mảng.

<img src="code/structured-programming/img/top-down-approach.png" class="center">

[Xem mã nguồn trên GitHub](https://github.com/nd-hung/oop/blob/main/docs/topics/overview/code/structured-programming/Program.cs)

## Phương pháp lập trình hướng đối tượng (Object Oriented Programming)

- Dựa trên cách tiếp cận hướng đối tượng. Theo đó, chương trình là tập hợp các đối tượng. Đối tượng là sự kết hợp giữa dữ liệu (thuộc tính) và các xử lý (phương thức) xoay quanh dữ liệu đó. Đối tượng thực hiện các yêu cầu xử lý thông qua cơ chế truyền thông điệp (message passing).

## Các nguyên lý cơ bản của lập trình hướng đối tượng

### Trừu tượng hóa (Abstraction)

Trừu tượng hóa là quá trình loại bỏ đi các thông tin, tính chất cụ thể của sự vật, hiện tượng và
giữ lại những tính chất, hành vi đặc trưng của chúng.

### Bao đóng (Encapsulation)

Trong phương pháp lập trình cấu trúc, dữ liệu và các chức năng xử lý tách rời nhau. Trong lập trình hướng đối tượng, dữ liệu và các xử lý xoay quanh dữ liệu đó được tích hợp trong một thực thể gọi là đối tượng.

Tính bao đóng cho phép người lập trình xác định mức độ truy cập đến thành viên của một lớp từ bên ngoài.
Theo đó, có thể chủ động ẩn đi các dữ liệu hoặc phương thức nhằm hạn chế những tác động không mong muốn từ bên ngoài lớp.

### Thừa kế (Inheritance)

Kỹ thuật thừa kế cho phép tạo một lớp mới kế thừa (sử dụng lại) các thành phần (thuộc tính, phương thức) của một lớp đã có. Kỹ thuật thừa kế thể hiện mối quan hệ tổng quát hóa - đặc biệt hóa trong thế giới thực. Ví dụ, hình vuông là một trường hợp đặc biệt của hình chữ nhật khi nó có 4 cạnh bằng nhau, khi đó ta nói hình vuông là trường hợp đặc biệt hóa của hình chữ nhật, hay nói cách khác, hình chữ nhật là trường hợp tổng quát hóa của hình vuông.

Khi lập trình áp dụng kỹ thuật thừa kế, lớp đặc biệt hóa sẽ kế thừa các thành phần của lớp tổng quát. Lớp tổng quát được gọi là lớp cơ sở/lớp cha (base/parent/super class), lớp đặc biệt hóa được gọi là lớp dẫn xuất/lớp con (derived/child/sub class).

> Chú ý: Lớp dẫn xuất chỉ được sử dụng các thành phần mà lớp cơ sở chia sẻ.

### Đa hình (Polymorphism)

Kỹ thuật đa hình xuất hiện khi sử dụng thừa kế trong lập trình. Đa hình cho phép xây dựng lớp cơ sở có những thành phần được viết ở mức tổng quát, sau đó các thành phần này được cài đặt chi tiết ở các lớp kế thừa. Đa hình cho phép cài đặt các phương thức cùng tên nhưng tùy theo loại đối tượng mà đoạn mã nguồn phù hợp sẽ được thực thi một cách linh hoạt.