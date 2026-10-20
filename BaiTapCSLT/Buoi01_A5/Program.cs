namespace Buoi01_A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // NHẬP (tạm gán sẵn giá trị)
            double a = 5, b = 3;

            // XỬ LÝ
            double cv = 2 * (a + b);
            double dt = a * b;
            double d = Math.Sqrt(a * a + b * b); // Tính đường chéo

            // XUẤT
            Console.WriteLine("--- KET QUA TINH TOAN ---");
            Console.WriteLine("Chiều dài = " + a);
            Console.WriteLine("Chiều rộng = " + b);
            Console.WriteLine("Chu vi = " + cv);
            Console.WriteLine("Diện tích = " + dt);
            Console.WriteLine("Đường chéo = " + d);

            Console.WriteLine();

            // TRẢ LỜI CÂU HỎI LÝ THUYẾT (Bước 4)
            Console.WriteLine("--- TRA LOI CAU HOI BUOC 4 ---");
            Console.WriteLine("Nếu đổi thành double cv = 2 * a + b; thì:");
            Console.WriteLine("- Chương trình KHÔNG báo lỗi cú pháp (vì đây là lỗi logic).");

            // Tính thử kết quả sai
            double cv_sai = 2 * a + b;
            Console.WriteLine("- Với a = 5, b = 3, chu vi in ra sẽ là: " + cv_sai + " (Sai, đúng phải là 16).");
            Console.WriteLine("- Lỗi này chỉ phát hiện được khi so sánh kết quả chạy với kết quả tính tay.");
        }
    }
}