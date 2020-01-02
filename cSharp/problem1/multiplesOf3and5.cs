/**
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
*/

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEulerProblem1
{

	public class MultiplesSequence
	{
		public static int[] getMultiplesIntArray(int limit)
		{	
			// Create list object to append multiples
			List<int> multiplesIntList = new List<int>();

			// Loop until count reaches limit
			for (int count = 0; count < limit; count++)
			{
				// Append each multiple of 5 to list
				if(count%5==0)
				{
					multiplesIntList.Add(count);
				}

				// Append each multiple of 3 to list
				else if(count%3==0)
				{
					multiplesIntList.Add(count);
				}
			}
			// Cpnvert list to array and return
			int[] multiplesIntArray = multiplesIntList.ToArray();
			return multiplesIntArray;
		}
	}

	class ArraySum 
	{
		private static int sum;
		
		public static int GetSum(int[] array)
		{
			sum = 0;

			for(int index = 0; index < array.Length; index++)
			{
				sum += array[index];
			}

			return sum;
		}
	}

	class Solution 
	{
		public static void Main(String[] args)
		{
			//To store answers
			int[] multiplesIntArray;
			int multiplesSumInt;
			string multiplesSumString;
			var lines = new List<string>();

			multiplesIntArray = MultiplesSequence.getMultiplesIntArray(10);
			multiplesSumInt = ArraySum.GetSum(multiplesIntArray);
			multiplesSumString = multiplesSumInt.ToString();
			lines.Add(multiplesSumString);

			multiplesIntArray = MultiplesSequence.getMultiplesIntArray(1000);
			multiplesSumInt = ArraySum.GetSum(multiplesIntArray);
			multiplesSumString = multiplesSumInt.ToString();
			lines.Add(multiplesSumString);


			// string[] multiplesStringArray = Array.ConvertAll(multiplesIntArray, x=>x.ToString());
			string directory = @"C:/Users/Public/problem1_solution.txt";
			// System.IO.File.WriteAllLines(solutionTextFile, multiplesStringArray);
			System.IO.File.WriteAllLines(directory, lines);
		}
	}
}