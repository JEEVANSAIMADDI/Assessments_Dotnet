using System;
class Assessment {
  static void Main() { 
    int[] input1={1,4,7,9};
    int input2=3;
    int n=input2;
    int a=input1[0];
    int[] arr={0,0,0};
    int cnt=0;
    
    if(isArithematic(input1)){
        int d=input1[1]-input1[0];
        for(int i=n-1;i<=n+1;i++){
            arr[cnt++]=a+(i-1)*d;
        }
    }
    else if(isGeometric(input1)){
        int r=input1[1]/input1[0];
        for(int i=n-1;i<=n+1;i++){
            arr[cnt++]=a*(int)Math.Pow(r,i-1);
        }
    }
        for(int i=0;i<3;i++){
            Console.WriteLine(arr[i]);
        }
  }
  
  public static bool isArithematic(int[] arr){
      if(arr.Length==1){
          return true;
      }
      int d=arr[1]-arr[0];
      for(int i=1;i<arr.Length-1;i++){
          if(arr[i+1]-arr[i]!=d){
                return false;
          }
      }
      return true;
  }
  
  public static bool isGeometric(int[] arr){
      if(arr.Length==1){
          return true;
      }
      int r=arr[1]/arr[0];
      for(int i=1;i<arr.Length-1;i++){
          if(arr[i+1]/arr[i]!=r){
                return false;
          }
      }
      return true;
  }
}