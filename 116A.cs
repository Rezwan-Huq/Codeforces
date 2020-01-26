using System;
public class Tram{
	static void Main(){
		int n = int.Parse(Console.ReadLine());
		int a=0, b=0, x=0, max=0;
		for(int i=0;i<n;i++){
			a= nextInt();
			b= nextInt();
			x=b-a+x;
			if(max<x){
				max= x;
			}
		}
		Console.WriteLine(max);
	}
	static string[] inputBuf;
  	static int inputBufCount;
   	static string next() {
      if(inputBuf == null || inputBufCount == inputBuf.Length) {
         inputBuf = nextLine().Split();
         inputBufCount = 0;
      }
      return inputBuf[inputBufCount++];
   }
   static string nextLine() {
      string inputStr;
      while((inputStr = Console.ReadLine()) != null && inputStr.Length == 0);
      return inputStr;
   }
   static int nextInt() {
      return int.Parse(next());
   }
   static long nextLong() {
      return long.Parse(next());
   }
   static double nextDouble() {
      return double.Parse(next());
   }
}