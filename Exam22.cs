/*
    input1=wel2come &hello69 @#wipro01
    output=9 
    
    input1=4 6 1 java^&23 >g7ood8 
    output=4
    
*/

using System;
class Assessment_SingleDigitSum{
    
    public static void Main(){
        
        string input1="4 6 1 java^&23 >g7ood8";
        int s=0;
        foreach(char ch in input1){
            if(Char.IsDigit(ch)){
                s+=ch-'0';
            }
        }
        if(s==0)
            Console.WriteLine(0);
        if(s%9==0)
            Console.WriteLine(9);
        else 
            Console.WriteLine(s%9);
        
    }
}