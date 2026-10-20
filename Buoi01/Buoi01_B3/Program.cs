namespace Buoi01_B3
{
    internal class program   // (tên lớp viết thường vẫn hợp lệ, không phải lỗi)
    {
        static void Main(string[] args)   // sửa: main -> Main
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;   // sửa: thiếu dấu ;
            Console.WriteLine("Chương trình có lỗi");   // sửa: console -> Console; thiếu dấu " đóng
            Console.WriteLine("Đường dẫn: C:\\Temp\\new");   // sửa: Writeline -> WriteLine; \T là escape không hợp lệ; \n sẽ xuống dòng (lỗi sai kết quả) -> dùng \\
            Console.WriteLine("Kết thúc");   // sửa: nháy đơn ' ' -> nháy kép " "
        }
    }
}   // sửa: thiếu một dấu } đóng ở cuối