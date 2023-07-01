using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.comm.msg.crypt_
{
	/// <summary>
	/// Phil Zimmerman invented Pretty Good Privacy (PGP), the de facto standard for email encryption.
	/// </summary>
	internal class IPgp
	{
		/*
		 *Alice 2 Bob:
		 *
		Generates random symmetric private key, $k_s$.
Encrypts her email with $k_s$ (for effiency)
Also encrypts $k_s$ with Bob's public key.
Alice digitally signs the encrypted message.
Alice sends Bob both cipher msg, crypted pass, and her digital signature. 
		 */
	}
}
