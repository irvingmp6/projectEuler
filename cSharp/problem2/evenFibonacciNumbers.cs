using System;
using System.Collections;
using System.Collections.Generic.List;

namespace ProjectEulerProblem2 
{
	public class FibonacciSequence 
	{
		public int[] generateSequence(int limit)
		{
			// Create new list object and append values 1 and 2
			List<int> sequenceList = new List<int>();
			sequenceList.Add(1);
			sequenceList.Add(2);

			int rightIndex; // To store the last Fibonacci term
			int leftIndex; // To store the second to last Fibonacci term
			
			while (sequenceList.Length <= limit)
			{
				// Calculate and assign the last two index values of the list
				rightIndex = sequenceList.Length - 2;
				leftIndex = sequenceList.Length - 1;

				// Calculate and append the next Fibonacci term
				fibonacciTerm = sequenceList[leftIndex] + sequenceList[rightIndex];
				sequenceList.Add(fibonacciTerm);
			}

			// Convert list to array and return
			int[] sequenceArray = sequenceList.ToArray();
			return sequenceArray;
		}
	}
}