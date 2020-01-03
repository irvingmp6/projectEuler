using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEulerProblem2 
{
	public class FibonacciSequence 
	{
		public static int[] Generate(int countLimit)
		{


			// Create new list object and append values 1 and 2
			List<int> sequenceList = new List<int>();
			sequenceList.Add(1);
			sequenceList.Add(2);

			int limit = countLimit - 2; // Remove the two default entries

			int rightIndex; // To store the last Fibonacci term
			int leftIndex; // To store the second to last Fibonacci term
			int fibonacciTerm; // To store the next Fibonacci term

			while (sequenceList.Count <= limit)
			{
				// Calculate and assign the last two index values of the list
				rightIndex = sequenceList.Count - 2;
				leftIndex = sequenceList.Count - 1;

				// Calculate and append the next Fibonacci term
				fibonacciTerm = sequenceList[leftIndex] + sequenceList[rightIndex];
				sequenceList.Add(fibonacciTerm);
			}

			// Convert list to array and return
			int[] sequenceArray = sequenceList.ToArray();
			return sequenceArray;
		}
	}
	public class Solution
	{
		public static void Main(String[] args)
		{
			string directory = @"C:/Users/Public/problem2_solution.txt";

			var sequenceInt = FibonacciSequence.Generate(100);
			int arrayLength = sequenceInt.Length;
			string[] lines = new string[arrayLength];
			
			for(int index = 0; index < arrayLength; index++)
			{
				lines[index] = sequenceInt[index].ToString();
			}

			System.IO.File.WriteAllLines(directory, lines);
		}
	}
}


