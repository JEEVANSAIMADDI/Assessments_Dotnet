/*
    input1=1 1 1 4 5
    output=21
    
    input1=1 2 3 3 5 5
    output=22
    
    input1=1 2 3 4 5 6 7 8 9 10
    output=00
    
*/


using System;
class Assessment_FindMissingNumber{
    
    public static void Main(){
       
       string input1="1 2 3 4 5 6 7 8 9 10";
       string[] ip=input1.Split(' ');
       int miss=0,dup=0;
       for(int i=1;i<=ip.Length;i++)
       {
           int c=0;
           for(int j=0;j<ip.Length;j++){
               int num=int.Parse(ip[j]);
               if(i==num){
                   c++;
               }
           }
           if(c==0){
                miss++;
           }
           if(c>1){
               dup++;
           }
       }
       Console.WriteLine(miss+""+dup);
    }
}