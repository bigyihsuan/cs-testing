using System;
using System.Collections;

namespace CSTesting {
	class Program {
		static void Main(string[] args) {
			Euler1();
			Euler2();
			Euler3();
			Euler4();

		}

		static void Euler1() {
			int sum = 0;
			for (int i = 1; i < 1000; i++) {
				if (i % 3 == 0 || i % 5 == 0) {
					sum += i;
				}
			}
			Console.Write("Euler #1: Sum is ");
			Console.WriteLine(sum);
		}

		private static int Fibonacci(int n) {
			if (n <= 1) {
				return n;
			} else {
				return Fibonacci(n - 1) + Fibonacci(n - 2);
			}
		}

		static void Euler2() {
			int sum = 0;
			int i = 1;
			while (true) {
				int fib = Fibonacci(i);
				if (fib % 2 == 0) {
					sum += fib;
				}
				if (fib >= 4e6) {
					Console.Write("Euler #2: Sum is ");
					Console.WriteLine(sum);
					return;
				}
				i++;
			}
		}

		private static ArrayList PrimeFactors(long n) {
			var factors = new ArrayList();
			long temp = n;
			if (temp % 2 == 0) {
				factors.Add(2);
				while (temp % 2 == 0) {
					temp /= 2;
				}
			}

			for (int i = 3; i <= Math.Sqrt(n); i+=2) {
				if (temp % i == 0) {
					factors.Add(i);
					while (temp % i == 0) {
						temp /= i;
					}
				}
			}
			if (temp > 2) {
				factors.Add(temp);
			}
			return factors;
		}

		static void Euler3() {
			var factors = PrimeFactors(600851475143);
			Console.WriteLine("Euler #3: Largest prime factor of 600851475143 is " + factors[factors.Count - 1]);
		}

		static void Euler4() {
			bool isPalidrome = false;
			long largest = 0;
			long product = 0;
			for (int i = 999; i >= 100; i--) {
				for (int j = 999; j >= 100; j--) {
					product = i * j;
					string p = product.ToString();
					var t = p.ToCharArray();
					Array.Reverse(t);
					string r = new String(t);

					isPalidrome = p.Contains(r);
					if (isPalidrome) {
						largest = product > largest ? product : largest;
					}
				}
			}
			
			Console.WriteLine("Euler #4: The largest palidrome is " + largest);
		}
	}
}
