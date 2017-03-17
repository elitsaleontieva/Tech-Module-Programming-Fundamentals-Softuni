
using System;

namespace CamelsBack
{
	class Program
	{
		public static void Main(string[] args)
		{
			var n = Console.ReadLine().Split().Select(int.Parse).ToList();
 
            var m = int.Parse(Console.ReadLine()); 
 				
			int rounds=0;
            while ( n.Count>m)
            {
                n.Remove(n[0]); 
				n.Remove(n[n.Count-1]); 
				rounds++;
            }
 			
		if(rounds==0){
			Console.WriteLine("already stable: {0}",String.Join(" ",n));
			
			
		} 
		else{
			Console.WriteLine("{0} rounds",rounds); 
			Console.WriteLine("remaining: {0}",String.Join(" ",n)); 
			
		}
           
	}
        }
}
