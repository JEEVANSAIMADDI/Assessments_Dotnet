/*

input1={"aaa","bb","cc"}
output=odd1even2

input1={"a","b","c"}
output=odd2even1

*/

using System;
class Assessment_FindAsciiSumOddEven{
    
    public static void Main(){
        string[] input1={"a","b","c"};
        int e=0,o=0;
        foreach(string each in input1){
            string s=each;
            int ascii=0;
            foreach(char ch in s){
                ascii+=(int)ch;
            }
            if(ascii%2==0){
                e+=1;
            }
            else{
                o+=1;
            }
        }
        Console.WriteLine("odd"+o+"even"+e);
    }
}