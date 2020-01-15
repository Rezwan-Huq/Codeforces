using System;

public class Team {
	static void Main() {
		int n = nextInt();
		int ans = 0;
		for(int i=0; i<n; i++) {
			int check = nextInt() + nextInt() + nextInt();
			if(check >= 2) ans++;
		}
		Console.WriteLine(ans);
	}


	// reader code
	static string[] inputBuf;
	static int inputBufCount;

	static Team() {
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