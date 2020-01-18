using System;
public class Capital{
	static void Main(){
		int m=0;
		char z='m';
		String s = Console.ReadLine();
		for(int i=0;i<s.Length;i++){
			if(s[0]>='A' && s[0]<='Z'){
				m=1;
				Console.WriteLine(s);
				break;
			}
			else if (s[0]>='a' && s[0]<='z') {
				z = (char)((int) s[0] -32);
			}
		}
		if(m==0){
			String y=""+z;
			for(int i=1;i<s.Length;i++){
				y= y+s[i];
			}
			Console.WriteLine(y);
		}
	}
}