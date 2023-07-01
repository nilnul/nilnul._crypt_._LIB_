using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.crypt
{
	/*
	 Per msdn:

	 To use public-key cryptography to digitally sign a message, Alice first applies a hash algorithm to the message to create a message digest. The message digest is a compact and unique representation of data. Alice then encrypts the message digest with her private key to create her personal signature. Upon receiving the message and signature, Bob decrypts the signature using Alice's public key to recover the message digest and hashes the message using the same hash algorithm that Alice used. If the message digest that Bob computes exactly matches the message digest received from Alice, Bob is assured that the message came from the possessor of the private key and that the data has not been modified. If Bob trusts that Alice is the possessor of the private key, he knows that the message came from Alice.

 Note

A signature can be verified by anyone because the sender's public key is common knowledge and is typically included in the digital signature format. This method does not retain the secrecy of the message; for the message to be secret, it must also be encrypted.
	 */
	/*
	 the msg, and the signature, comprise a co, which amounts to a predicate of equation, and the predicate gives whether it's true or false.
	 */

	/// <summary>
	/// when you encrypt, you use other's pub key to encrypt the msg;
	/// when you signature, you use your own private key to encrypt the msg's hash again. anybody, including the other, can get the hash. but only bob can get the msg;
	/// 
	/// </summary>
	/// <remarks>
	/// Digital signatures provide message authentication, message integrity and non-repudiation.
	/// </remarks>
	/// (cryptobook.nakov.com/encryption-symmetric-and-asymmetric)
	interface ISignature
	{
	}
}
