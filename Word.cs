using System;
public class Word{
	static void Main(){
		int x = int.Parse(Console.ReadLine());
		for (int i=0; i<x; i++) {
			string str = Console.ReadLine();
			if (str.Length<=10){
				Console.WriteLine(str);

			}
			else {
				Console.WriteLine(str.Substring(0,1) + (str.Length - 2) + str.Substring(str.Length - 1));

			}
		}

	}
}