using System;
public class Banana{
	static void Main(){
		int a=nextInt();
		int t=nextInt();
		int n=nextInt();
		int ans = ((n*(n+1)/2)*a) - t;
		if(ans<= 0){
			Console.WriteLine("0");
		}
		else{
			Console.WriteLine(ans);
		}
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