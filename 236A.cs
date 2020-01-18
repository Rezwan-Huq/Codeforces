using System;
public class Profile{
	static void Main(){
		int x=0;
		string s = Console.ReadLine();
		int[] count = new int[26];
		for(int i=0; i<s.Length; i++){
			int index = s[i]-'a';
			count[index] = count[index] + 1; 
		}
		for(int i=0; i<26;i++){
			if(count[i]>0){
				x++;
			}
		}
		if(x%2==0){
			Console.WriteLine("CHAT WITH HER!");
		}
		else{
			Console.WriteLine("IGNORE HIM!");
		}
	}
}