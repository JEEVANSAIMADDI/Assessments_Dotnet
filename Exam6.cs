/*
    input1=SWA 
    output=AQA 
    
    input1=KIng HiLLs
    output=HY,j FpJJf
    
    input1=Go cArT
    output=D[ bAyE
*/

using System;
using System.Collections.Generic;
class Assessment_QwertyKeyboard_FindNext{
  public static void Main() {
    string input1="Go cArT";
    string one="QWERTYUIOP[]";
    string two="ASDFGHJKL;'";
    string three="ZXCVBNM,.";
    string four="qwertyuiop[]";
    string five="asdfghjkl;'";
    string six="zxcvbnm,.";
    string op="";
    foreach(char ch in input1){
        if(one.IndexOf(ch)>=0){
            int index=one.IndexOf(ch);
            if(index==0 || index==1){
                op+="Q";
            }
            else{
                op+=one[index-2];
            }
        }
        else if(two.IndexOf(ch)>=0){
            int index=two.IndexOf(ch);
            if(index==0 || index==1){
                op+="A";
            }
            else{
                op+=two[index-2];
            }
        }
        else if(three.IndexOf(ch)>=0){
            int index=three.IndexOf(ch);
            if(index==0 || index==1){
                op+="Z";
            }
            else{
                op+=three[index-2];
            }
        }
        else if(four.IndexOf(ch)>=0){
            int index=four.IndexOf(ch);
            op+=four[index+2];
        }
        else if(five.IndexOf(ch)>=0){
            int index=five.IndexOf(ch);
            op+=five[index+2];
        }
        else if(six.IndexOf(ch)>=0){
            int index=six.IndexOf(ch);
            op+=six[index+2];
        }
        else if(ch==' '){
            op+=" ";
        }
    }
    Console.WriteLine(op);
  }
}