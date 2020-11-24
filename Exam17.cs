/*
     input1={"arc","nep","tis"};
     input2={"sit","car","pen"};
     output=120
    
     input1={"cnhul","estl","rakeb","ahev"};
     input2={"lets","have","lunch","break"};
     output=2031

*/
using System;
class Assesment_MatchingNumber_Jumbled {
  static void Main() {
   string[] input1={"cnhul","estl","rakeb","ahev"};
   string[] input2={"lets","have","lunch","break"};
    int input3=4;
    string ans="";
    for(int i=0;i<input3;i++){
        char[] ch1=input1[i].ToCharArray();
        Array.Sort(ch1);
        string s1=new string(ch1);
        for(int j=0;j<input3;j++){
             char[] ch2=input2[j].ToCharArray();
            Array.Sort(ch2);
            string s2=new string(ch2);
            if(s1.Equals(s2)){
                ans+=j;  
            }
        }
    }
        Console.WriteLine(ans);
  }
}