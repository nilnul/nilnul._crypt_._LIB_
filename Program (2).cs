using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.uinteger;

namespace nilnul.info.crypt
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine(ExtendedGcd.Eval(12,6));
			Primes.PopulateAnotherBatch();
			Rsa rsa = new Rsa();
			Console.WriteLine("{0},{1},{2}",rsa.productOfPrimes,rsa.encrypt,rsa.decrypt);
			Console.WriteLine(rsa.decryptIt(rsa.encryptIt(134)));
			
		}
	}
}
