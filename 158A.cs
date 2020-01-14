using System;
public class round{
	static void Main(String[] args){
		int n,k;
		String str = Console.ReadLine();
		char[] seperator = {' '};
		int count = 2;
		String[] strlist = str.Split(seperator, count, StringSplitOptions.None);
		n= int.Parse(strlist[0]); 
		k= int.Parse(strlist[1]);
		str = Console.ReadLine();
		strlist = str.Split(seperator, n, StringSplitOptions.None);
		int[] array = new int[n];
		for(int i=0;i<n;i++){
			array[i]=int.Parse(strlist[i]);
		}
		int c=0;
		for(int i=0;i<n;i++){
			if(array[i] >= array[k-1] && array[i]>0){
				c++;	
			}
		}
		Console.WriteLine(c);

	}
}