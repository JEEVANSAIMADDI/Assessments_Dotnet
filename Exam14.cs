/*
   input1=3521,input2=2452,input3=1352
   output=1522
    
*/
using System;
public class Assessment_FindKey
{
	public static void Main() {
	    int input1=3521,input2=2452,input3=1352;
	    int[] ones={input1%10,input2%10,input3%10};
	    int[] tens={(input1/10)%10,(input2/10)%10,(input3/10)%10};
	    int[] huns={(input1/100)%10,(input2/100)%10,(input3/100)%10};
	    int[] thous={(input1/1000)%10,(input2/1000)%10,(input3/1000)%10};
	    Array.Sort(ones);
	    Array.Sort(tens);
	    Array.Sort(huns);
	    Array.Sort(thous);
	    int ans=thous[0]*1000 + huns[2]*100 +tens[0]*10 + ones[2];
	    Console.WriteLine(ans);
	}
}
