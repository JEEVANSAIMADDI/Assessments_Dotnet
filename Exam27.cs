/*
  
    input1=grammar
    output=g r a m m a r 
    
    input1=this is a good girl
    output=t h i s i s a g o o d g i r l

*/
using System;
class Assessment {
  static void Main() {
     string op="";
     string input1="this is a good girl";
     for(int i=0;i<input1.Length;i++){
         if(input1[i]==' '){
             continue;
         }
         else{
            op+=input1[i]+" ";
         }
     }
     Console.WriteLine(op.Trim());
  }
}