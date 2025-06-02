using OOP5_Clone;

Customer c1=new Customer();
c1.Id = 1;
c1.Name = "Obama";

Customer c2 = c1;
//Lúc này c1 và c2 cùng trỏ tới 1 ô nhớ
//1 ô nhớ có từ 2 đối tượng trở lên trỏ vào ==>alias
//c1 đổi làm c2 đổi và ngược lại

Customer c3 = c1.copy();
//lúc này sao chép toàn bộ dữ liệu tại ô nhớ c1 đang quản lý
//sang 1 ô nhớ mới hoàn toàn và giao cho c3 quản lý
//lúc này c3 đổi ko liên quan c1 và ngược lại