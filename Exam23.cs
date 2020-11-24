/*
     input1={12,5,121}
     output=9
     
     input1={10,22,33}
     output=1
     
*/

using System;
using System.Collections.Generic;

class Assessment_SumOfPalNums{
    
    public static void Main(){
        
        int[] input1={10,22,33};
        int s=0;
        foreach(int num in input1){
            if(isPal(num)){
                s+=num;
            }
        }
        if(s==0){
            Console.WriteLine(0);
        }
        else if(s%9==0){
            Console.WriteLine(9);
        }
        else{
             Console.WriteLine(s%9);
        }
    }
    
    public static bool isPal(int n){
        int rev=0,num=n;
        while(n!=0){
            rev=rev*10+n%10;
            n/=10;
        }
        if(rev==num){
            return true;
        }
        return false;
    }
}