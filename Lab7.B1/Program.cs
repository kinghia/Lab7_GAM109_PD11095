using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.B1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> nums = new List<int>() { 1, 3, 4, 5, 8, 9 };
            string str = "chao mung den voi binh nguyen vo tan";
            string strc = "CHAO mung DEN Voi binh nguyen vo tan";

            Console.WriteLine("Bài 1: ");
            Console.WriteLine("Câu a: xuất ra bình phương của các số lớn hơn 4 ");
            var binhPhuongThan4 = from bp in nums
                                  where bp > 4
                                  select bp * bp ;
            foreach (var item in binhPhuongThan4)
            {
                Console.WriteLine("Bình phương lớn hơn 4: " + item, item + item);
            }

            Console.WriteLine("\nCâu b: xuất ra màn hình lần lượt số lần xuất hiện của từng chữ");
            var rs = str.Where(Char.IsLetter).GroupBy(x => x)
                .Select(group => new { Chữ = group.Key, Đếm = group.Count() });
            foreach ( var item in rs)
            {
                Console.WriteLine(item + "");
            }

            Console.WriteLine("\nCâu c: xuất ra màn hình những chuỗi được viết hoa toàn bộ");
            var words = strc.Split(' ');
            var result = from word in words
                         where word.Equals(word.ToUpper())
                         select word;
            foreach ( var itemc in result)
            {
                Console.WriteLine(itemc  + " ");
            }
        }
    }
}
