/*
    1)input1=3
     input2={5,0,-5}
     output=1
    
    2)input1=4
    input2={1,2,3,-6}
    output=3
    
    3)input1=4
    input2={-1,0,1,0}
    output=2
    
    4)input1=3
    input2={1,2,3}
    output=-1
    
*/

using System;
using System.Collections.Generic;
class Assessment_FundTransfer{
  public static void Main() {
     int input1=3;
     int[] input2={5,0,-5};
     int sum=0;
     for(int i=0;i<input1;i++){
        sum+=input2[i]; 
     }
     if(sum!=0){
        Console.WriteLine(-1);
        System.Environment.Exit(0);
     }
     
     int ans=input1-1;
     Dictionary<int,int> dict=new Dictionary<int,int>();
     for(int i=0;i<input1;i++){
        sum+=input2[i];
        if(!dict.ContainsKey(sum)){
            dict[sum]=1;
        }
        else{
            dict[sum]++;
        }
        ans=Math.Min(ans,input1-dict[sum]);
     }
    Console.WriteLine(ans);
  }
}