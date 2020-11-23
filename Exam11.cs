/*

input1=1+2+3
output=3+2+1

input1= 1+2+3+1+2
output= 3+2+2+1+1

input1=1+89+2+3+1+2+10
output=89+10+3+2+2+1+1

*/

using System;
class Assessment_LearningAddition{
    
    public static void Main(){
        string input1="1+89+2+3+1+2+10";
        string[] ip=input1.Split('+');
        int[] ip1=new int[ip.Length];
        int c=0;
        foreach(string each in ip){
            ip1[c++]=int.Parse(each);
        }
        string op="";
        Array.Sort(ip1);
        for(int i=ip1.Length-1;i>=0;i--){
            op+=ip1[i]+"+";
        }
        
        Console.WriteLine(op.Substring(0,op.Length-1));
    }
}