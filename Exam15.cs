/*
    input1=3521,input2=2452,input3=1352
    output=(5+5+5)+(1+2+1)=19
    
*/

using System;
public class Assessment_FindKey
{
	public static void Main() {
	    int input1=3521,input2=2452,input3=1352;
	    int[] arr1=new int[4];
	    int[] arr2=new int[4];
	    int[] arr3=new int[4];
	    int cnt1=0,cnt2=0,cnt3=0;
	    while(input1!=0){
	        arr1[cnt1++]=input1%10;
	        input1/=10;
	    }
	    while(input2!=0){
	        arr2[cnt2++]=input2%10;
	        input2/=10;
	    }
	    while(input3!=0){
	        arr3[cnt3++]=input3%10;
	        input3/=10;
	    }
	 Array.Sort(arr1);
	 Array.Sort(arr2);
	 Array.Sort(arr3);
	 int sum=(arr1[3]+arr2[3]+arr3[3])+(arr1[0]+arr2[0]+arr3[0]);
	 Console.WriteLine(sum);

	}
}