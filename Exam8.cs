/*

input1=1 ,input2=1 ,input3=3
output=48

input1=5 ,input2=1 ,input3=2
output=979

*/

using System;
class Assessment_Arithematic_Fibonacci{
    
    public static void Main(){
        int input1=1 ,input2=1 ,input3=3,s=0;
        for(int i=1;i<=input3;i++){
            s+=input1+(i-1)*input2;
        }
        Console.Write(s*nthFibonnaci(s));
    }
    
    public static int nthFibonnaci(int n){
        int a=0,b=1,c=0;
        for(int i=2;i<=n;i++){
            c=a+b;
            a=b;
            b=c;
        }
        return c;
    }
}