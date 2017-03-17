/*
 * Created by SharpDevelop.
 * User: Eli
 * Date: 1/29/2017
 * Time: 12:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace sss
{
	class Program
	{
		public static void Main(string[] args)
		{
			string firstname = Console.ReadLine();
			string lastname = Console.ReadLine();
			string ageSTRING = Console.ReadLine();
			int age=int.Parse(ageSTRING);
			Console.WriteLine("Hello, {0} {1}.\r\nYou are {2} years old.", firstname,lastname,age); 
		}
	}
}