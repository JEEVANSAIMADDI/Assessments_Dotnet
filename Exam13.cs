/*
    input1=7788899,input2=4545,input3=123
    output=24
    
    input1=123,input2=0,input3=951426
    output=22
    
*/
using System;
public class Assessment_SilverNumber
{
        public static void Main() {
		
        int input1=123,input2=0,input3=951426;
        string ip1=input1.ToString();
        string ip2=input2.ToString();
        string ip3=input3.ToString();
        int s=0;
        int num=Convert(ip1)+Convert(ip2)+Convert(ip3);
       
        while(num!=0){
            s+=num%10;
            num/=10;
        }
        
        Console.WriteLine(s);
	}
	public static int Convert(string s){
        string op="";
        foreach(char ch in s){
            if(ch=='7' || ch=='8' || ch=='9'){
                op+="1";
            }
            else if(ch=='4' || ch=='5' || ch=='6'){
                op+="2";
            }
            else if(ch=='1' || ch=='2' || ch=='3'){
                op+="3";
            }
            else if(ch=='0'){
                op+="0";
            }
        }	    
        return int.Parse(op);
      }
}