using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.crypt_
{
	/// <summary>
	/// xor the data with a stream of pseudo random;
	/// </summary>
	 interface StreamI
	{
		IEnumerable<byte> encrypt(IEnumerable<byte> data);
		IEnumerable<byte> decrypt(IEnumerable<byte> data);

	}
}
