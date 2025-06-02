using OOP4_Dictionary;
using System.Text;

Category laptop=new Category ();
laptop.Id = 1;
laptop.Name = "Danh mục Laptop";

Product dell1=new Product() 
    { Id = 1,Name="Dell 1",Quantity=10,Price=15000000 };
laptop.AddProduct(dell1);
Product dell2 = new Product()
{ Id = 2, Name = "Dell 2", Quantity = 30, Price = 17000000 };
laptop.AddProduct(dell2);
Product HP1 = new Product()
{ Id = 3, Name = "HP 1", Quantity = 5, Price = 12000000 };
laptop.AddProduct(HP1);

Product HP2 = new Product()
{ Id = 4, Name = "HP 2", Quantity = 7, Price = 12000000 };
laptop.AddProduct(HP2);


Console.OutputEncoding=Encoding.UTF8;
Console.WriteLine("Danh sách sản phẩm của danh mục Laptop:");
laptop.PrintAllProducts();

Console.WriteLine("Mời bạn nhập vào mã sản phẩm muốn tìm:");
int pid=int.Parse(Console.ReadLine());
Product p=laptop.GetProduct(pid);
if(p==null)
{
    Console.WriteLine("Không tìm thấy sản phẩm có mã ="+pid);
}
else
{
    Console.WriteLine("Đã tìm thấy sản phẩm có mã = "+pid);
    Console.WriteLine(p);
}

Console.WriteLine("- Danh sách chưa sắp xếp:");
laptop.PrintAllProducts();
Dictionary<int, Product> sortedproducts = laptop.SortProduct();
Console.WriteLine("- Danh sách sau khi sắp xếp:");
foreach(KeyValuePair<int, Product> item in sortedproducts)
{
    Product x = item.Value;
    Console.WriteLine(x);    
}


Dictionary<int, Product> complextSorts = laptop.ComplexSort();
Console.WriteLine("- Danh sách sau khi sắp xếp Phức tạp:");
foreach (KeyValuePair<int, Product> item in complextSorts)
{
    Product x = item.Value;
    Console.WriteLine(x);
}

Product px = new Product();
px.Id = 1;
px.Name = "MAC BOOK 1000";
px.Quantity = 80;
px.Price = 500;
laptop.EditProduct(px);
Console.WriteLine("---Danh sách sản phẩm sau khi sửa ----");
laptop.PrintAllProducts();

int pid_remove = 1;
laptop.RemoveProduct(pid_remove);
Console.WriteLine("---Danh sách sản phẩm sau khi xóa ----");
laptop.PrintAllProducts();


