using System;
public class Maths{
	static void Main(){
		String s = Console.ReadLine();
		int x=0,y=0,z=0;
		for(int i=0;i<s.Length;i=i+2){
			switch (s[i]) 
			{
				case '1':
					x++;
					break;
				case '2' : 
					y++;
					break;
				case '3' :
					z++;
					break;	
			}

		}
		if(x>0){
			Console.Write("1");
		}
		for(int i=1;i<x;i++){
			Console.Write("+1");	
		}
		if(y>0){
			if(x>0){
				Console.Write("+2");
			}
			else {
				Console.Write("2");
				}
		}
		for(int i=1;i<y;i++){
			Console.Write("+2");	
		}
		if(z>0){
			if(x>0 || y>0){
				Console.Write("+3");
			}
				// else if(y>0){
				// 	Console.Write("+3");
				// }
			else {
				Console.Write("3");
			}
		}
		for(int i=1;i<z;i++){
		Console.Write("+3");	
		}
		
		Console.WriteLine("");
	}	 
}

