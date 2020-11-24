/*
    input1=5
    input2={10,11,7,12,14}
    output=4

*/
using System;
public class Assessment_MaximumDifference
{
	public static void Main() {
		
		int input1=5;
		int[] input2={10,11,7,12,14};
		int max=input2[0]-input2[1];
		for(int i=1;i<input1-1;i++)
		{
		    int diff=input2[i]-input2[i+1];
		    max=Math.Max(max,diff);
		}
		Console.WriteLine(max);
	}
}
