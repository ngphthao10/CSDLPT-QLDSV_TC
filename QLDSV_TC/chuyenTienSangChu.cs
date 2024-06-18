using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_TC
{
    class chuyenTienSangChu
    {
        static string[] ones = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        static string[] teens = { "", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
        static string[] tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

        static public string ConvertToText(long number)
        {
            if (number == 0)
                return "không đồng";

            string text = "";

            if (number >= 1000000000)
            {
                text += ConvertToText(number / 1000000000) + " tỷ";
                number %= 1000000000;
                if (number > 0) text += " ";
            }

            if (number >= 1000000)
            {
                text += ConvertToText(number / 1000000) + " triệu";
                number %= 1000000;
                if (number > 0) text += " ";
            }

            if (number >= 1000)
            {
                text += ConvertToText(number / 1000) + " nghìn";
                number %= 1000;
                if (number > 0) text += " ";
            }

            if (number >= 100)
            {
                text += ones[number / 100] + " trăm";
                number %= 100;
                if (number > 0) text += " ";
            }

            if (number >= 10 && number <= 19)
            {
                text += teens[number % 10];
            }
            else
            {
                if (number >= 20)
                {
                    text += tens[number / 10];
                    if (number % 10 > 0) text += " ";
                }
                if (number % 10 > 0)
                {
                    text += ones[number % 10];
                }
            }

            return text + " đồng";
        }
    }

}
