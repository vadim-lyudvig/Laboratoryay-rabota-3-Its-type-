using System;
using System.Collections.Generic;
using System.Text;

namespace СС
{
    public class CountingSystem
    {
        public string number { get; set; }
        public string ss { get; set; }
        public CountingSystem()
        {
            number = "101010";
            ss = "2";
        }
        public CountingSystem(string number, string ss)
        {
            this.ss = ss;
            this.number = number;
        }
        public string ConvertNumber(string ss)
        {
            if (this.ss == ss)
            {
                return "";
            }
            int number = 0;
            try
            {
                number = Convert.ToInt32(this.number, int.Parse(this.ss));
            }
            catch(Exception ex)
            {
                return "Не верная система счисления";
            }
            this.number = Convert.ToString(number, int.Parse(ss));
            this.ss = ss;
            return "";
        }
        public static CountingSystem operator + (CountingSystem ss1, CountingSystem ss2)
        {
            ss1.ConvertNumber("10");
            ss2.ConvertNumber("10");
            int num1 = int.Parse(ss1.number);
            int num2 = int.Parse(ss2.number);
            var result = new CountingSystem();
            result.ss = "10";
            result.number = (num1 + num2).ToString();
            return result;
        }
        public static CountingSystem operator -(CountingSystem ss1, CountingSystem ss2)
        {
            ss1.ConvertNumber("10");
            ss2.ConvertNumber("10");
            int num1 = int.Parse(ss1.number);
            int num2 = int.Parse(ss2.number);
            var result = new CountingSystem();
            result.ss = "10";
            result.number = (num1 - num2).ToString();
            return result;
        }
        public static CountingSystem operator *(CountingSystem ss1, CountingSystem ss2)
        {
            ss1.ConvertNumber("10");
            ss2.ConvertNumber("10");
            int num1 = int.Parse(ss1.number);
            int num2 = int.Parse(ss2.number);
            var result = new CountingSystem();
            result.ss = "10";
            result.number = (num1 * num2).ToString();
            return result;
        }

        public static bool operator <(CountingSystem ss1, CountingSystem ss2)
        {
            ss1.ConvertNumber("10");
            ss2.ConvertNumber("10");
            int num1 = int.Parse(ss1.number);
            int num2 = int.Parse(ss2.number);
            if (num1 < num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(CountingSystem ss1, CountingSystem ss2)
        {
            ss1.ConvertNumber("10");
            ss2.ConvertNumber("10");
            int num1 = int.Parse(ss1.number);
            int num2 = int.Parse(ss2.number);
            if (num1 > num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator == (CountingSystem ss1, CountingSystem ss2)
        {
            ss1.ConvertNumber("10");
            ss2.ConvertNumber("10");
            int num1 = int.Parse(ss1.number);
            int num2 = int.Parse(ss2.number);
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (CountingSystem ss1, CountingSystem ss2)
        {
            ss1.ConvertNumber("10");
            ss2.ConvertNumber("10");
            int num1 = int.Parse(ss1.number);
            int num2 = int.Parse(ss2.number);
            if (num1 != num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
