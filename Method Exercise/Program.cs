using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("What is favorite your name");
			var name = Console.ReadLine();

			Console.WriteLine("What is your favorite age");
			var age = Console.ReadLine();

			Console.WriteLine("What is your favorite band");
			var band = Console.ReadLine();

			Console.WriteLine("What is your favorite color ");
			var color  = Console.ReadLine();

			Console.WriteLine($"Nice to meet you {name} thank you for letting me know your {age}" +
				$", your favorite band; {band}, and your favorite ; {color}");

			Console.WriteLine("Write a number to be used");	
			int num1= int.Parse(Console.ReadLine());
			
			Console.WriteLine("Write another number to be used");
			int num2 = int.Parse(Console.ReadLine());

			var result = Add(num1, num2);
			Console.WriteLine($"The result is {result}");

			Console.WriteLine("Write a number to be used");
			int mul1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Write another number to be used");
			int mul2 = int.Parse(Console.ReadLine());

			var product = Multiply(mul1, mul2);
			Console.WriteLine($"The result is {product}");

			Console.WriteLine("Write a number to be used");
			int sub1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Write another number to be used");
			int sub2 = int.Parse(Console.ReadLine());

			var difference = Add(sub1, sub2);
			Console.WriteLine($"The result is {difference}");

			Console.WriteLine("Write a number to be used");
			int div1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Write another number to be used");
			int div2 = int.Parse(Console.ReadLine());

			var divedend = Add(div1, div2);
			Console.WriteLine($"The result is {divedend}");

		}

		public static int Add(int num1, int num2)
        {
			return num1 + num2;
        }

		public static int Multiply(int mul1, int mul2)
		{
			return mul1 * mul2;
		}
		public static int Subtract (int sub1, int sub2)
		{
			return sub1 - sub2;
		}
		public static int Division (int div1, int div2)
		{
			return div1 / div2;
		}

	}


}
