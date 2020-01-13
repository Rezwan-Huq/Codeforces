using System;
public class Theater {
	static void Main() {
		// String Tokenization for INPUT
		String str = Console.ReadLine();
		char[] seperator = {' '}; 
        int count = 3; 
        String[] strlist = str.Split(seperator, count, StringSplitOptions.None);
		//end
		double m, n, a;
		m = double.Parse(strlist[0]);
		n = double.Parse(strlist[1]);
		a = double.Parse(strlist[2]);
		
		ulong ln = (ulong)Math.Ceiling(n/a);
		ulong lm = (ulong)Math.Ceiling(m/a);
		ulong z = ln * lm;
		Console.WriteLine(z);
	}

}