using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._crypt
{
	static public class _SaltX
	{
		public static byte[] GenerateRandomSalt()
		{

			//Source: http://www.dotnetperls.com/rngcryptoserviceprovider
			byte[] data = new byte[32];

			using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
			{
				// Ten iterations.
				for (int i = 0; i < 10; i++) /*Well, good question. I do not trust completely, when I add this code to the program, I thought, it may provide a little extra security and cost little CPU time and memory. – Joe Sep */
				{
					// Fill buffer.
					rng.GetBytes(data);
				}
			}
			return data;
		}

	}
}
