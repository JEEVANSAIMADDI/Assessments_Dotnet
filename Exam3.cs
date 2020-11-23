/*
    1)input1={123456,1234567}
    output={CN361728,WN1617283}
    
    2)input1={12}
    output={WN36}
*/

using System;
class  Assessment_TransformCodes{
  public static void Main() {
    int[] input1={123456,1234567};
    string[] output=new string[input1.Length];
    int cnt=0;
    
    foreach(int each in input1){
        int n=each;
        string op="";
 
        // Step-1
        
        if(n.ToString().Length==6) op+="C";
        else op+="W";
        
        // Step-2
        
        if(n==0) op+="Z";
        else if(n==1) op+="O";
        else if(isPrime(n)) op+="P";
        else op+="N";
        
        // Step-3
        
        op+=sum(n);
        
        // Step-4
        
        if(n%2==0) op+=(n/2);
        else op+=(n-1)/2;
 
        output[cnt++]=op;
        
    }
    
    foreach(string s in output){
        Console.WriteLine(s);
    }
    
  }    
    public static bool isPrime(int n){
        if(n<=1){
            return false;
        }
        for(int i=2;i<=Math.Sqrt(n);i++){
            if(n%i==0){
                return false;
            }
        }
        return true;
    }
    
    public static int sum(int n){
        int s=0;
        while(n!=0){
            s+=n%10;
            n/=10;
        }
        if(s%9==0) return 9;
        else return s%9;
    }
}