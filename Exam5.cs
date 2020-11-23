/*
    1)input1= AA99
      output= AB00
    
    2)input1= AA99
      output= AB00

    3)input1= BC01
      output= BC02
    
    4)input1= ZY99
      output= ZZ00
      
    5)input1= OP99
      output= OQ00

*/

using System;
using System.Collections.Generic;
class Assessment_FindNextElementInSeries{
  public static void Main() {
    string input1="OP99";
    string op="";
    int num=int.Parse(input1.Substring(2));
    if(num==99 && input1.Substring(1,1)=="Z"){
        op+=(char)((int)input1[0]+1)+"A00";
    }
    else if(num==99){
        op+=input1.Substring(0,1)+(char)((int)input1[1]+1)+"00";
    }
    else if(num>=9 && num<99){
        op+=input1.Substring(0,2)+(num+1);
    }
    else if(num<9){
        op+=input1.Substring(0,2)+"0"+(num+1);
    }
    Console.WriteLine(op);
  }
}