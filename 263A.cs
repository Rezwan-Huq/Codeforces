using System;
public class Matrix{
   static void Main(){
      int m= 5, n=5, i=0;
      int dr=2, dc=2;
      int sr=0, sc=0;
      int[,] mat= new int[5,5];
      for(i=0; i<m; i++){
         for(int j=0; j<n; j++){
            mat[i,j] = nextInt();
            if(mat[i,j]==1){
               sr=i; sc=j;
            }
         }
      }
      
      Console.WriteLine(func(dr,sr)+func(dc,sc));


   }
   static int func(int x,int y){
      int vr=0;
      vr= x-y;
      if(vr<0){
         vr= vr*(-1);
      }
      return vr;
   }
   static string[] inputBuf;
   static int inputBufCount;
   static string next() {
      if(inputBuf == null || inputBufCount == inputBuf.Length) {
         inputBuf = nextLine().Split();
         inputBufCount = 0;
      }
      return inputBuf[inputBufCount++];
   }
   static string nextLine() {
      string inputStr;
      while((inputStr = Console.ReadLine()) != null && inputStr.Length == 0);
      return inputStr;
   }
   static int nextInt() {
      return int.Parse(next());
   }
   static long nextLong() {
      return long.Parse(next());
   }
   static double nextDouble() {
      return double.Parse(next());
   }
}