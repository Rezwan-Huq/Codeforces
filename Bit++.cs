using System;
public class Bit{
	static void Main(){
		int n;
		n = int.Parse(next());
		int x=0;
		for(int i=0; i<n; i++){
			string m= Console.ReadLine();
			x += ( (m=="++X" || m=="X++")? 1: -1 );

		}
		Console.WriteLine(x);
	}
	

	 //reader code
	static string[] inputBuf;
	static int inputBufCount;

	static Bit() {
		inputBuf = null;
		inputBufCount = 0;
	}

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
