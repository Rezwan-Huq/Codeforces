using System;
using System.Text; 
public class GFG{
	static void Main(){
		String str= Console.ReadLine();
		StringBuilder x = new StringBuilder();
		for(int i=0;i<str.Length;i++){
			char c =str[i];
			switch (c) 
			{
				case 'A':
					continue;
					
				case 'a':
					continue;
					
				case 'E':
					continue;
					
				case 'e':
					continue;
					
				case 'I':
					continue;
					
				case 'i':
					continue;
					
				case 'O':
					continue;
					
				case 'o':
					continue;
					
				case 'U':
					continue;
					
				case 'u':
					continue;
					
				case 'Y':
					continue;
					
				case 'y':
					continue;

					
				 
			}
			x.Append(".");
			x.Append((""+c).ToLower());

		}

		Console.WriteLine(""+x);	
	}
}