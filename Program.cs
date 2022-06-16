using System;
using System.Collections.Generic;
using System.Linq;

namespace Implementation_ALgo
{
    public class Program
	{
		float a, b, c, x;

		static public float? FirstEquation(float a, float b)
		{
			if (a == 0)
			{

				if (b == 0)
				{
					System.Console.WriteLine("valeur A = zéro et valeur B = zéro => X peut avoir n\'inporte quelle valeur", a, b);
					return float.NaN;
				}
				else
				{

					System.Console.WriteLine("Il n\'y a pas de solution, c\'est un ensemble vide.", a, b);
					return null;
				}
			}
			else
			{
				float x = (float)-b / a;
				return x;

			}

		}

		static public float[] SecondEquation (float a, float b, float c) 
		{

			float delta, x1, x2;

			if (a == 0) 
			{
				if (b == 0) 
				{
					if (c == 0)
					{
						System.Console.WriteLine("valeur A = zéro, valeur B = zéro, valeur C = zéro => X peut avoir n\'inporte quelle valeur", a, b, c);
						List<float> d = new List<float>();
						d.Add(a);
						d.Add(b);
						d.Add(c);
						return d.ToArray();
					}
					else 
					{
						System.Console.WriteLine("Aucune solution.");
						return null; // new float[] { }; //
 					}
				}
				else
				{
					float x = -c / b;
					List<float> d1 = new List<float>();
					d1.Add(x);
					return d1.ToArray();
				}
			} else
            {
				delta = (b * b) - (4 * a * c);

				if (delta == 0)
				{
					float x = (float)-b / (2 * a);
					List<float> d2 = new List<float>();
					d2.Add(x);
					return d2.ToArray();
				}
				else if (delta > 0.0)
				{
					x1 = (float)((-b - System.Math.Sqrt(delta)) / (2 * a));
					x2 = (float)((-b + System.Math.Sqrt(delta)) / (2 * a));
					List<float> d3 = new List<float>();
					d3.Add(x1);
					d3.Add(x2);
					return d3.ToArray();
				}

				else
				{

					System.Console.WriteLine("Aucune solution.");
					return null; // new float[] { }; //
				}
			}
		}

		static public object BinarySearchAlgo(int[] inputArray, int key, int min, int max)
		{
			if (min > max)
			{
				return null;
			}
			else
			{
				int mid = (min + max) / 2;
				if (key == inputArray[mid])
				{
					return mid;
				}
				else if (key < inputArray[mid])
				{
					return BinarySearchAlgo(inputArray, key, min, mid - 1);
				}
				else
				{
					return BinarySearchAlgo(inputArray, key, mid + 1, max);
				}
			}
		}

		static void Main(string[] args)
		{
			// print result FirstEquation
			Console.WriteLine(FirstEquation(2, 7));

			// print result SecondEquation
			foreach (float solution in SecondEquation(15, 37, 6))
			{
				Console.WriteLine(solution);
			}

			// print result BynarySearchAlgo
			List<int> myArray = new List<int>(new int[] { 0, 1, 2, 3, 4 });
		
				Console.WriteLine(BinarySearchAlgo(myArray.ToArray(), 3, 0, 4));
			
		}
    }
}
