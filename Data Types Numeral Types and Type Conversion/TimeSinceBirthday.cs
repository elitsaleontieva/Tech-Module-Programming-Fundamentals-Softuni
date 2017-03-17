/*
 * Created by SharpDevelop.
 * User: Eli
 * Date: 1/25/2017
 * Time: 5:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TimeSinceBirthday
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Write program to enter an integer number of years and convert
//it to days, hours and minutes
			Console.Write("Years - ");
				var years=byte.Parse(Console.ReadLine());
			int days = years*365;
			int hours = days*24;
			int minutes=hours*60;
			Console.WriteLine("{0} years = {1} days = {2} hours" +
			                  "= {3} minutes.", years, days, hours, minutes);
			}
		
				
		}
	
}