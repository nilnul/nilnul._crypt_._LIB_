using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._crypt.key.of_.kdf_
{
	/// <summary>
	/// HMAC-based key derivation function (HKDF)
	/// ,where HMAC is Hashed Message Authentication Code;
	/// HKDF is specified in RFC 5869
	/// </summary>
	/// <remarks>
	///It's designed to derive key material from some high-entropy input, such as the output of an ECDH key agreement operation.
	///It's not designed to derive keys from relatively low-entropy inputs such as passwords. For that, use PBKDF2.
	/// </remarks>
	/// alias:
	///		HKDF
	///		hKdf
	///		HKdf
	///		
	internal interface IHmacKdf:IKeyDerivationFunction
	{
	}
}
