/*

input1=5 , input2=6
output=18

input1=3 , input2=4
output=21

*/

using System;
class Assessment_FindCalculation{
    
    public static void Main(){
        int input1=3 ,input2=4,s=0;
        for(int i=1;i<=input2;i++){
            input1=input1*input2;
        }
        while(input1!=0){
            s+=input1%10;
            input1/=10;
        }
        Console.WriteLine(s);
    }
}