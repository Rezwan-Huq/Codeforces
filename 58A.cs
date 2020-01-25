using System;
public class Hello{
	static void Main(){
		String s = Console.ReadLine();
		String x= "hello";
		int pos=0;
		for(int i=0; i<s.Length; i++){
			if(pos==5)
				break;
			if(s[i]== x[pos]){
				pos++;
			}
		} 
		if(pos==5){
			Console.WriteLine("YES");
		}
		else{
			Console.WriteLine("NO");
		}
	}
}