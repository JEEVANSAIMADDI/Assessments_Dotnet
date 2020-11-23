/*

1)input1 = {"hello","madam"}
  output = {"hlohlohlo","mdmmdmmdm"}

*/

using System;
class  Assessment{
  static void Main() {
    string[] input1={"hello","madam"};
    int input2=2;
    string[] output=new string[input1.Length];
    int cnt=0;
    foreach(string each in input1){
        string s=each;
        string fst=s.Substring(0,1);
        string mid=s.Substring(s.Length/2,1);
        string lst=s.Substring(s.Length-1,1);
        string op=fst+mid+lst;
        string op1="";
        for(int i=0;i<=input2;i++){
            op1+=op;
        }
        output[cnt++]=op1;    
    }
    for(int i=0;i<cnt;i++){
        Console.WriteLine(output[i]);
    }
  }
}