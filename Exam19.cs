/*
    input1={1,2,3,4,5}
    input2=5
    output=2
    
    input1={5,6,7,8,9,10}
    input2=6
    output=6

*/


using System;
class Assessment_SumOfElementsOfModifiedArray{
    
    public static void Main(){
        
        int[] input1={5,6,7,8,9,10};
        int  input2=6;
        int sum=0;
        if(input2%2==0){
            for(int i=0;i<input2;i++){
                if(i%2==0){
                    continue;
                }
                else{
                    sum+=input1[i];
                }
            }
        }
        else{
            for(int i=0;i<input2;i++){
                if(i%2!=0){
                    sum+=1;
                }
                else{
                    sum+=input1[i];
                }
            }
        }
        if(sum==0)
            Console.WriteLine(sum);
        else if(sum%9==0)
            Console.WriteLine(9);
        else 
            Console.WriteLine(sum%9);
    }
}