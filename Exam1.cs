/*

1)input1 = WIPRO
  output = IO:152

2)input1 = Fia88201Ot
  output = aO:176
  
3)input1 = noon
  output = n:n

4)input1 = cup
  output = c:p

*/

using System;
class Assessment_PrimeChars {
  static void Main() {
    string input1="cup";
    int sum=0;
    string op="";
    foreach(char ch in input1){
        int num=(int)ch;
        if(isPrime(num)){
            sum+=num;
            op+=ch;
        }
    }
    if(sum==0){
        Console.Write(input1[0]+":"+input1[input1.Length-1]);
    }
    else{
        Console.Write(op+":"+sum);
    }
  }
  public static bool isPrime(int n){
      if(n<=1){
          return false;
      }
      for(int i=2;i<=Math.Sqrt(n);i++){
          if(n%i==0){
              return false;
          }
      }
      return true;
  }
}
