using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.natural;

namespace nilnul.data.crypt
{
	public partial class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine(ExtendedGcd.Eval(12,6));
			PrimeController1201042215.PopulateSomeMore2(100);
			Rsa rsa = new Rsa();
			Console.WriteLine("{0},{1},{2}", rsa.productOfPrimes, rsa.encrypt, rsa.decrypt);
			Console.WriteLine(rsa.decryptIt(rsa.encryptIt(134)));

		}
	}
}
