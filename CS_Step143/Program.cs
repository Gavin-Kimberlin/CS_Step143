using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step143
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.Add(123);
            nums.Add(321);
            nums.Add(42);
            nums.Add(69);
            nums.Add(81);
            nums.Add(14);
            nums.Add(38);
            nums.Add(678);
            nums.Add(94);
            nums.Add(77);

            Console.WriteLine("Enter a number:");

            try
            {
                int numInput = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < 10; i++)
                {
                    int divide = nums[i] / numInput; //Dividing by 0 returns infinity; Dividing by a string returns 'Input string was not in a correct format.'
                    Console.WriteLine(nums[i] + " divided by " + numInput + " is " + divide);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type a whole number");
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don\'t divide by zero");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

            Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution");
            Console.ReadLine();
        }
    }
}
