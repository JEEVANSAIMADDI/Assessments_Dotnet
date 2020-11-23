/*

input1=Human intelligence created wonders in the world
output=Human i1e created wonders in the world

input1=All the computer applications should contain localization option to make the application more user friendly
output=All the computer a1s should contain l1n option to make the a9n more user friendly 

*/

using System;
class Assessment_LongWords{
    
    public static void Main(){
        string input1="All the computer applications should contain localization option to make the application more user friendly";
        string[] ip=input1.Split(' ');
        string op="";
        foreach(string s in ip){
            int len=s.Length;
            if(len>10){
                op+=s.Substring(0,1)+sum(len-2)+s.Substring(len-1,1);
            }
            else{
                op+=s;
            }
            op+=" ";
        }
        Console.WriteLine(op.Trim());
    }
    public static int sum(int n){
        int s=0;
        while(n!=0){
            s+=n%10;
            n/=10;
        }
        if(s==0){
            return 0;
        }
        else if(s%9==0){
            return 9;
        }
        return s%9;
    }
}