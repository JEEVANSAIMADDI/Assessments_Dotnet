/*

input1={47,65,51,12,29,32,34}
input2=7
output=65

input1={74,-56,15,71,92,23}
input2=6
output=15

input1={74,56,15,71,92,-23}
input2=6
output=15



*/

using System;
using System.Collections.Generic;
class Assessment_TraverseArray_FindKey {
  static void Main() {
   
    int[] input1={47,65,51,12,29,32,34};
    int input2=7;
    int flag=0,max=0,op=0;
        for(int i=0;i<input2;i++){
            if(input1[i]<0){
                flag=1;
                break;
            }
            if(max<=input1[i]){
                max=input1[i];
            }
           
        }

        List<int> li=new List<int>();
        if(flag==1){
            int first=input1[0];
            while(first>=0){
                if(length(first)==3){
                    li.Add(first/100);
                    first=input1[first%100]; 
                }
                else{
                    li.Add(first/10);
                    first=input1[first%10];
                }
            }
           
                li.Add((first/10)*-1);
                
                op+=li[0];
                
                for(int j=1;j<li.Count;j++){
                    if(j%2!=0){
                        op+=li[j];
                    }
                    else{
                        op-=li[j];
                    }
                }
            }
        
        else{
            op=max;
        }
        Console.Write(op);
    }

    public static int length(int n ){
        n=Math.Abs(n);
        int c=0;
        while(n!=0){
            c++;
            n/=10;
        }
        return c;
    }
}