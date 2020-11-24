/*
    input1="Rajiv",input2="Roy",input3=560037,input4=6
    output=VrOY75
    
    input1="Kumud",input2="Kumar",input3=561327,input4=2
    output=DkUMAR62

input1="Manoj",input2="Kumar",input3=561327,input4=2
    output=JkUMAR62
    
*/

using System;
public class Assessment_UserIDGeneration
{
       public static void Main() {
        string input1="Rajiv",input2="Roy";
        int input3=560037,input4=6;
        string[] ip={input1,input2};
        Array.Sort(ip);
        int len1=input1.Length,len2=input2.Length;
        string op="";
        string max="",min="";
        string ip3=input3.ToString();
        if(len1==len2){
            max=ip[1];
            min=ip[0];
        }
        else if(len1>len2){
            max=input1;
            min=input2;
        }
        else{
            max=input2;
            min=input1;
        }
        string output=max[max.Length-1]+min+ip3[input4-1]+ip3[ip3.Length-input4];
        foreach(char ch in output){
            if(Char.IsUpper(ch)){
                op+=Char.ToLower(ch);
            }
            else{
                op+=Char.ToUpper(ch);
            }
        }
        Console.WriteLine(op);
       }
}
