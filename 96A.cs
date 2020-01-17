using System;
public class Football{
	static void Main(){
		String x = Console.ReadLine();
		int count=1;
		for(int i=1;i<x.Length;i++){
			if(x[i] == x[i-1]){
				count++;
				if(count>=7){
					Console.WriteLine("YES");
					return;
				}
			}
			else if(x[i] != x[i-1]){
					count =1;	
			}
		}
		Console.WriteLine("NO");
	}
}