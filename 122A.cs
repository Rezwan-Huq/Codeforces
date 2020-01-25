using System;
public class Number{
	static void Main(){
		int x= int.Parse(Console.ReadLine());
		int[] s = {4, 7, 44, 47, 74, 77, 444, 447, 474, 477, 744, 747, 774, 777};
		for(int i=0; i<s.Length; i++){
			if(x%s[i]==0){
				Console.WriteLine("YES");
				return;
			}		
		}
		Console.WriteLine("NO");
		
	}
}