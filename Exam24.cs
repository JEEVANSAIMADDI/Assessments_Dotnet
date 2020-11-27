/*
   input1="AAA",input2="BBB",input3="CCC"
  output=A3B3C3
  
  input1="AAA",input2="BCD",input3="EFEE"
  output=A3B1C1D1E3F1
  
  input1="AMAN",input2="EFEE",input3="CCC"
  output=A2M1N1E3F1C3
  
*/
using System;
using System.Collections.Generic;
class Assessment_findEncode {
  static void Main() {
    string input1="AMAN",input2="EFEE",input3="CCC";
    string ip=input1+input2+input3;
    Dictionary<char,int> dict=new Dictionary<char,int>();
    foreach(char ch in ip){
        if(!dict.ContainsKey(ch)){
            dict[ch]=1;
        }
        else{
            dict[ch]++;
        }
    }
    foreach(KeyValuePair<char,int> entry in dict){
        Console.Write(entry.Key+""+entry.Value);
    }
    
  }
}