namespace Buoi01_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(@"   /\
  /  \
 /____\
 |    |
 |_[]_|");

            Console.WriteLine();

            Console.WriteLine("Câu hỏi: Điều gì xảy ra nếu ở bước 3 chỉ viết một dấu \\ ở cuối chuỗi, ví dụ \" /\\\"?");
            Console.WriteLine("Giải thích: Trình biên dịch báo lỗi CS1010 vì dấu \\ escape dấu \" làm chuỗi không đóng lại được. Phải viết \\\\ hoặc dùng @\"\".");
        }
    }
}