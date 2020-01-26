using System;
public class Twins{
	static void Main(){
		int n=0, sum=0,x=0,count=0;
		n= nextInt();
		int[] a= new int[n];
		for(int i=0;i<n;i++){
			a[i]= nextInt();
			sum = sum+a[i];
		}
		Array.Sort(a);
		Array.Reverse(a);

		for(int i=0; i<n; i++){
			x=x+a[i];
			sum=sum-a[i];
			count++;
			if(x>sum){
				break;
			}

		}
		Console.WriteLine(count);

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