using System;
public class Taxi{
	static void Main(){
		int n = nextInt();
		int sum=0, x=0, y=0, z=0, w=0;
		for(int i=0; i<n; i++){
			int t=nextInt();
			if(t==4){
				x++;
			}
			else if(t==3){
				y++;
			}
			else if(t==2){
				z++;
			}
			else{
				w++;
			}
		}
		sum=x;
		sum=sum+y;
		sum=sum+z/2;
		if(z%2==1){
			sum=sum+1;
		}
		if(w>y){
			w=w-y;
			if(w>0 && z%2==1){
				w=w-2;
			}
			if(w>0){
				sum=sum+w/4;
				if(w%4!=0)
					sum++;
			}
		}

		Console.WriteLine(sum);

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