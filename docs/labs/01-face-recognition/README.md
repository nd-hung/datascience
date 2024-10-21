# Hệ thống nhận dạng khuôn mặt (face recognition)

---

## Mô tả bài toán

- Xây dựng một hệ thống có khả năng nhận dạng khuôn mặt của các SV trong lớp.

<img src="figs/example.PNG">

## Thu thập & chuẩn bị dữ liệu

- Mỗi sv chụp 60 ảnh khuôn mặt:
  - Ảnh màu, điều kiện ánh sáng ban ngày, định dạng JPG
  - Chụp nhiều góc độ khác nhau của khuôn mặt
  - Kích thước < 2 MB

## Phân tích khám phá dữ liệu (Exploratory Data Analysis - EDA)
### Thống kê số lượng mẫu
- Dữ liệu đủ số lượng?
- Sự cân bằng dữ liệu giữa các lớp?

number_classes = {'Class_0': len(os.listdir(healthy_dir)),
'Class_1': len(os.listdir(blight_dir)),
'Class_2': len(os.listdir(gray_dir)),
'Class_3': len(os.listdir(rust_dir))}
Next, plot a simple bar chart using keys and values for the axis.

plt.bar(number_classes.keys(), number_classes.values(), width = .5);
plt.title("Number of Images by Class");
plt.xlabel('Class Name');
plt.ylabel('# Images');


## Các cách tiếp cận giải quyết bài toán

### Phương pháp tryền thống

Logistic regression, neural networks, decision tree, support vector machine, random forest, naive Bayes, k-nearest neighbor

### Convolutional Neural Network (CNN)

- Xây dựng mô hình
- Huấn luyện mô hình
- Xây dựng, triển khai ứng dụng

## Phân tích, đánh giá

### Đánh giá kết quả

### Cải tiến kết quả

- Dữ liệu
- Mô hình
- Kỹ thuật huấn luyện
