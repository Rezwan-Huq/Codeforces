using System;
public class Stones{
	static void Main(){
		int count=0;
		int x=int.Parse(Console.ReadLine());
		String s = Console.ReadLine();
		for(int i=0; i<s.Length-1; i++){
			if(s[i]==s[i+1])
			count++;
		}
		Console.WriteLine(count);
	}
}