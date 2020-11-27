/*
    input1="11-09-1990"
    input2=1692
    output=Dare

*/


using System;
class Assessment_LuckyDare {
  static void Main() {
    string input1="11-09-1990";
    int input2=1692;
    string[] ip=input1.Split('-');
    int s1=0;
    for(int i=0;i<ip.Length;i++){
        int n=int.Parse(ip[i]);
        s1+=sum(n);
    }
    int s2=sum(input2);
    if(s1==s2){
        Console.WriteLine("Lucky");
    }
    else{
         Console.WriteLine("Dare");
    }
    
  }
  public static int sum(int n){
      int s=0;
      while(n!=0){
          s+=n%10;
          n/=10;
      }
      if(s==0){
          return 0;
      }
      else if(s%9==0){
          return 9;
      }
      else{
          return s%9;
      }
    }
}