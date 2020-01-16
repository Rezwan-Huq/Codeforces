using System;
public class Strings{
	static void Main(){
		string x,y;
		x=Console.ReadLine();
		y=Console.ReadLine();
		x = x.ToLower();
		y = y.ToLower();
		int i=0;
		for (i=0; i<x.Length; i++) 
		{
			if(x[i]>y[i]){
				Console.WriteLine("1");
				break;
			}
			else if(x[i]<y[i]){
				Console.WriteLine("-1");
				break;
			}
		}
		if (i==x.Length){
			Console.WriteLine("0");
		}
	}
}