 /*
    input1={3,2}
    input2=PN
    input3=2
    output=100
    
    input1={4,3,5}
    input2="PNP"
    input3=3
    ouput=600
    
*/

using System;
class Assessment_Electrostatics{
    
    public static void Main(){
        
        int[] input1={4,3,5};
        string input2="PNP";
        int input3=3;
        int sum=0;
        for(int i=0;i<input3;i++){
            if(input2[i]=='P'){
                sum+=input1[i];
            }
            else if(input2[i]=='N'){
                sum-=input1[i];
            }
        }
        Console.Write(sum*100);
    }
}